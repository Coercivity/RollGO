using LobbyAPI.Hubs.Helpers;
using LobbyAPI.Hubs.Models;
using LobbyAPI.Services;

namespace LobbyAPI.Hubs;

public class LobbyManager(IMeetingService meetingService, IFilmsDataService kinopoiskDataClient, IUserService userService)
{
    private readonly IMeetingService _meetingService = meetingService;
    private readonly IFilmsDataService _kinopoiskDataClient = kinopoiskDataClient;
    private readonly IUserService _userService = userService;

    public async Task<HashSet<LobbyActiveUser>?> JoinLobby(
        Guid lobbyId,
        Guid userId,
        string connectionId
    )
    {
        var activeMeeting = _meetingService.GetActiveMeetingByLobbyId(lobbyId);

        var activeUser = _meetingService.GetActiveUserFromMeeting(activeMeeting, userId);
        if (activeUser != null)
        {
            _meetingService.AddConnectionToActiveUser(connectionId, activeUser);
            return null;
        }

        await _meetingService.AddActiveUserToMeeting(userId, activeMeeting);

        return activeMeeting.ActiveUsers;
    }

    public async Task DisconnectUser(string connectionId)
    {
        var user = _meetingService.GetActiveUserByConnectionId(connectionId);
        if (user == null || !user.Connections.Any())
        {
            return;
        }

        if (user.Connections.Count() == 1)
        {
            _meetingService.RemoveUserFromMeeting(user, connectionId);
        }

        _meetingService.RemoveConnectionFromActiveUser(connectionId, user);
    }

    public async Task JoinLobbyAnonymous(Guid lobbyId, string userName, string connectionId)
    {
        var activeMeeting = _meetingService.GetActiveMeetingByLobbyId(lobbyId);

        var activeUser = _meetingService.GetActiveUserByMeeting(activeMeeting, connectionId);

        if (activeUser != null)
        {
            _meetingService.AddConnectionToActiveUser(connectionId, activeUser);
            return;
        }

        ////TODO : handle anonymous user
        //var userId = Guid.NewGuid();
        //await _meetingService.AddActiveUserToMeeting(userId, activeMeeting);
    }

    internal async Task<List<UserWithEntity>?> AddEntertainmentEntity(Guid userId, Guid lobbyId, int entertainmentEntityId)
    {
        ActiveMeeting activeMeeting = _meetingService.GetActiveMeetingByLobbyId(lobbyId);
        if (activeMeeting is null) return null;

        var entertainmentEntity = await _kinopoiskDataClient.GetFilm(entertainmentEntityId);
        if (entertainmentEntity is null) return null;

        var user = await _userService.GetUserById(userId);
        if (user is null) return null;

        activeMeeting.AddOrUpdateEntertainmentEntities(user, entertainmentEntity);

        return activeMeeting.GetEntertainmentEntitiesList();
    }

    internal async Task<List<UserWithEntity>?> RemoveEntertainmentEntity(Guid userId, Guid lobbyId, int entertainmentEntityId)
    {
        ActiveMeeting activeMeeting = _meetingService.GetActiveMeetingByLobbyId(lobbyId);
        if (activeMeeting is null) return null;

        var user = await _userService.GetUserById(userId);
        if (user is null) return null;

        activeMeeting.RemoveEntertainmentEntity(user, entertainmentEntityId);

        return activeMeeting.GetEntertainmentEntitiesList();
    }


    internal Task<HashSet<LobbyActiveUser>>? SetUserReady(Guid userId, Guid lobbyId, bool isReady)
    {
        ActiveMeeting activeMeeting = _meetingService.GetActiveMeetingByLobbyId(lobbyId);
        if (activeMeeting is null) return null;

        activeMeeting.ActiveUsers.FirstOrDefault(x => x.User.Id == userId).IsReady = isReady;
        return Task.FromResult(activeMeeting.ActiveUsers);
    }

    internal Task<UserWithEntity> StartRoll(Guid userId, Guid lobbyId)
    {
        ActiveMeeting activeMeeting = _meetingService.GetActiveMeetingByLobbyId(lobbyId);
        if(activeMeeting.Meeting.Lobby.AdminId != userId)
        {
            throw new Exception("Not lobby admin");
        }
        //TODO add rollingservice
        var winner = activeMeeting.AddedEntertainmentEntities.FirstOrDefault(x => x.Value.Any());
        //TODO add winner to meeting service 

        return Task.FromResult(new UserWithEntity
        {
            EntertainmentEntity = winner.Value.FirstOrDefault(),
            User = winner.Key
        });
    }
}




