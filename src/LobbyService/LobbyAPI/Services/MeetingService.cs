using Infrastructure.Repository;
using LobbyAPI.Hubs;

namespace LobbyAPI.Services
{
    public class MeetingService(IMeetingRepository meetingRepository, UserService userService)
    {
        private readonly IMeetingRepository _meetingRepository = meetingRepository;
        private readonly UserService _userService = userService;

        public HashSet<ActiveMeeting> ActiveMeetings { get; } = [];

        public ActiveMeeting GetActiveMeetingByLobbyId(Guid lobbyId) =>
            ActiveMeetings.FirstOrDefault(x => x.Meeting.Lobby.Id.Equals(lobbyId) && x.Meeting.IsActive == true)
            ?? throw new Exception();

        public LobbyUser GetActiveUserByMeeting(ActiveMeeting meeting, string connectionId) =>
            ActiveMeetings.FirstOrDefault(x => x.Meeting.Equals(meeting))?
            .Users.Where(x => x.Connections.Equals(connectionId)).FirstOrDefault()
            ?? throw new Exception();

        public LobbyUser GetActiveUserFromMeeting(ActiveMeeting activeMeeting, Guid userId) =>
            activeMeeting.Users.FirstOrDefault(x => x.User.Id.Equals(userId)) 
            ?? throw new Exception();

        public LobbyUser GetActiveUserByConnectionId(string connectionId)
        {
            foreach (var activeMeeting in ActiveMeetings)
            {
                var user = activeMeeting.Users.FirstOrDefault(u => u.Connections.Any(c => c.ConnectionId == connectionId));
                if (user != null)
                {
                    return user;
                }
            }
            throw new Exception();
        }


        public void AddConnectionToActiveUser(string connectionId, LobbyUser activeUser) =>
            activeUser.AddConnection(connectionId);

        public void RemoveConnectionFromActiveUser(string connectionId, LobbyUser activeUser) =>
            activeUser.RemoveConnection(connectionId);

        public async Task AddActiveUserToMeeting(Guid userId, ActiveMeeting activeMeeting)
        {
            var user = await _userService.GetUserById(userId);
            activeMeeting.Users.Add(new LobbyUser(user));
        }
    }
}