using LobbyAPI.Services;

namespace LobbyAPI.Hubs
{
    public class LobbyManager(UserService userService, MeetingService meetingService, KinopoiskDataService kinopoiskDataClient)
    {
        private readonly UserService _userService = userService;
        private readonly MeetingService _meetingService = meetingService;
        private readonly KinopoiskDataService _kinopoiskDataClient = kinopoiskDataClient;


        public async Task<HashSet<LobbyUser>?> JoinLobby(Guid lobbyId, Guid userId, string connectionId)
        {
            var activeMeeting = _meetingService.GetActiveMeetingByLobbyId(lobbyId);

            var activeUser = _meetingService.GetActiveUserFromMeeting(activeMeeting, userId);
            if (activeUser != null)
            {
                _meetingService.AddConnectionToActiveUser(connectionId);
                activeUser.AddConnection(connectionId);
                return null;
            }

            var user = await _userService.GetUserById(userId);
            _meetingService.AddActiveUserToMeeting(user, activeMeeting);
            
            return activeMeeting.Users;
        }

        public async Task DisconnectUser(string connectionId)
        {
            var user = GetConnectedUserById(connectionId);
            if (user == null || !user.Connections.Any())
            {
                return;
            }

            if (user.Connections.Count() == 1)
            {
                //ActiveMeetings.Where(x => x.Users.Where(x => x.Connections.Any(x => x.ConnectionId.Equals(connectionId)))).Remove(user);
                //here i need to remove user from one of active meeting 
            }

            user.RemoveConnection(connectionId);
        }

        public async Task JoinLobbyAnonymous(Guid lobbyId, string userName, string connectionId)
        {
            var activeMeeting = _meetingService.GetActiveMeetingByLobbyId(lobbyId);

            var activeUser = _meetingService.GetActiveUserByMeeting(activeMeeting, connectionId);

            if (activeUser != null)
            {
                activeUser.AddConnection(connectionId);
                return;
            }

            ActiveUsers.Add(new LobbyUser(userId));
        }

    }
}
