using LobbyAPI.Services;
using Microsoft.AspNetCore.SignalR;

namespace LobbyAPI.Hubs
{
    public class LobbyHub(LobbyManager lobbyManager) : Hub
    {
        private readonly LobbyManager _lobbyManager = lobbyManager;

        public void CreateLobby(Guid lobbyId)
        {
            _lobbyManager.CreateLobby(lobbyId);
            Groups.AddToGroupAsync(Context.ConnectionId, lobbyId);
        }

        public void JoinLobby(Guid lobbyId)
        {
            _lobbyManager.JoinLobby(lobbyId, Context.ConnectionId);
            Groups.AddToGroupAsync(Context.ConnectionId, lobbyId);
            Clients.Group(lobbyId).SendAsync(LobbyActions.UserJoined, Context.ConnectionId);
        }

        public List<Guid> GetUsersInLobby(Guid lobbyId)
        {
            return _lobbyManager.GetUsersInLobby(lobbyId);
        }
    }
}
