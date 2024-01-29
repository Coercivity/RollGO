using LobbyAPI.Hubs.Models;

namespace LobbyAPI.Services;

public interface IMeetingService
{
    public HashSet<ActiveMeeting> ActiveMeetings { get; set; }

    public ActiveMeeting GetActiveMeetingByLobbyId(Guid lobbyId);

    public LobbyActiveUser? GetActiveUserByMeeting(ActiveMeeting meeting, string connectionId);

    public LobbyActiveUser GetActiveUserFromMeeting(ActiveMeeting activeMeeting, Guid userId);

    public LobbyActiveUser GetActiveUserByConnectionId(string connectionId);

    public ActiveMeeting GetActiveMeetingByConnectionId(string connectionId);

    public void AddConnectionToActiveUser(string connectionId, LobbyActiveUser activeUser);

    public void RemoveConnectionFromActiveUser(string connectionId, LobbyActiveUser activeUser);

    public Task AddActiveUserToMeeting(Guid userId, ActiveMeeting activeMeeting);

    public void RemoveUserFromMeeting(LobbyActiveUser user, string connectionId);
}
