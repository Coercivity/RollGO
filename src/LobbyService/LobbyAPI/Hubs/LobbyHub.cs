using System.Security.Authentication;
using System.Security.Claims;
using Microsoft.AspNetCore.SignalR;

namespace LobbyAPI.Hubs;

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
        Guid userId = GetUserId();

        await _lobbyManager.JoinLobby(lobbyId, userId, Context.ConnectionId);

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

    public async Task AddMovie(Guid lobbyId, int entertainmentEntityId)
    {
        Guid userId = GetUserId(); 
        var usersWithEntities = await _lobbyManager.AddEntertainmentEntity(userId, lobbyId, entertainmentEntityId);
        await Clients.Group(lobbyId.ToString()).SendAsync(LobbyActions.MoviesChanged, usersWithEntities);
    }

    public async Task RemoveMovie(Guid lobbyId, int entertainmentEntityId)
    {
        Guid userId = GetUserId(); 
        var usersWithEntities = await _lobbyManager.RemoveEntertainmentEntity(userId, lobbyId, entertainmentEntityId);
        await Clients.Group(lobbyId.ToString()).SendAsync(LobbyActions.MoviesChanged, usersWithEntities);
    }
    
    public async Task SetUserReady(Guid lobbyId, bool isReady)
    {
        Guid userId = GetUserId();
        var users = await _lobbyManager.SetUserReady(userId, lobbyId, isReady);
        await Clients.Group(lobbyId.ToString()).SendAsync(LobbyActions.UsersReadyStateChanged, users);
    }

    public async Task StartRoll(Guid lobbyId)
    {
        Guid userId = GetUserId();
        var winner = await _lobbyManager.StartRoll(userId, lobbyId);
        await Clients.Group(lobbyId.ToString()).SendAsync(LobbyActions.RollEnded, winner);
    }

    private Guid GetUserId()
    {
        if (!Context.User?.Identity?.IsAuthenticated ?? true)
            throw new AuthenticationException("User is not authorized");
        return Guid.Parse(
            Context.User?.FindFirst(x => x.Type == ClaimTypes.NameIdentifier)!.Value!
        );
    }
}
