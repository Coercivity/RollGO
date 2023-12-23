using Domain.Entities;
using LobbyAPI.Services;

namespace LobbyAPI.Hubs
{
    public class LobbyManager( MeetingService meetingService, FilmsDataService kinopoiskDataClient)
    {
        private readonly MeetingService _meetingService = meetingService;
        private readonly FilmsDataService _kinopoiskDataClient = kinopoiskDataClient;

        public async Task<HashSet<LobbyUser>?> JoinLobby(Guid lobbyId, Guid userId, string connectionId)
        {
            var activeMeeting = _meetingService.GetActiveMeetingByLobbyId(lobbyId);

            var activeUser = _meetingService.GetActiveUserFromMeeting(activeMeeting, userId);
            if (activeUser != null)
            {
                _meetingService.AddConnectionToActiveUser(connectionId, activeUser);
                return null;
            }

            await _meetingService.AddActiveUserToMeeting(userId, activeMeeting);
            
            return activeMeeting.Users;
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

            //TODO : handle anonymous user
            var userId = Guid.NewGuid();
            await _meetingService.AddActiveUserToMeeting(userId, activeMeeting);
        }

    }
}
