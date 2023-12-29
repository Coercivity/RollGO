using System.Security.Authentication;
using System.Security.Claims;
using Microsoft.AspNetCore.SignalR;

namespace LobbyAPI.Hubs
{
    public class LobbyHub(LobbyManager lobbyManager) : Hub
    {
        private readonly LobbyManager _lobbyManager = lobbyManager;

        public override async Task OnConnectedAsync()
        {
            var connectionId = Context.ConnectionId;
            await Clients.Client(connectionId).SendAsync(LobbyActions.OnConnect, connectionId);
            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            var connectionId = Context.ConnectionId;
            await Clients.Client(connectionId).SendAsync(LobbyActions.OnDisconnect, connectionId);
            await _lobbyManager.DisconnectUser(connectionId);
            await base.OnDisconnectedAsync(exception);
        }

        public async Task JoinLobby(Guid lobbyId)
        {
            if (!Context.User?.Identity?.IsAuthenticated ?? true)
                throw new AuthenticationException("User not authorized");

            Guid userGuid = Guid.Parse(
                Context.User?.FindFirst(x => x.ValueType == ClaimTypes.NameIdentifier)!.Value!
            );
            await _lobbyManager.JoinLobby(lobbyId, userGuid, Context.ConnectionId);

            await Groups.AddToGroupAsync(Context.ConnectionId, lobbyId.ToString());
            await Clients
                .Group(lobbyId.ToString())
                .SendAsync(LobbyActions.UserJoined, Context.ConnectionId);
        }

        public async Task JoinLobbyAnonymous(Guid lobbyId, string userName)
        {
            await _lobbyManager.JoinLobbyAnonymous(lobbyId, userName, Context.ConnectionId);

            await Groups.AddToGroupAsync(Context.ConnectionId, lobbyId.ToString());
            await Clients
                .Group(lobbyId.ToString())
                .SendAsync(LobbyActions.AnonymousUserJoined, Context.ConnectionId);
        }
    }
}
