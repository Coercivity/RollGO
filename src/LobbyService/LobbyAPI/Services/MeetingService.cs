using Infrastructure.Repository;
using LobbyAPI.Hubs;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;

namespace LobbyAPI.Services
{
    public class MeetingService(
        IMeetingRepository meetingRepository,
        IUserService userService,
        IDistributedCache cache
    )
    {
        private readonly IMeetingRepository _meetingRepository = meetingRepository;
        private readonly IUserService _userService = userService;
        private readonly IDistributedCache _cache = cache;

        public HashSet<ActiveMeeting> ActiveMeetings
        {
            get
            {
                var cachedMeetings = _cache.GetString("ActiveMeetings");
                return cachedMeetings != null
                    ? JsonConvert.DeserializeObject<HashSet<ActiveMeeting>>(cachedMeetings)
                    : [];
            }
            set
            {
                var serializedMeetings = JsonConvert.SerializeObject(value);
                _cache.SetString("ActiveMeetings", serializedMeetings);
            }
        }

        public ActiveMeeting GetActiveMeetingByLobbyId(Guid lobbyId) =>
            ActiveMeetings.FirstOrDefault(
                x => x.Meeting.Lobby.Id.Equals(lobbyId) && x.Meeting.IsActive == true
            ) ?? throw new Exception();

        public LobbyActiveUser GetActiveUserByMeeting(ActiveMeeting meeting, string connectionId) =>
            ActiveMeetings
                .FirstOrDefault(x => x.Meeting.Equals(meeting))
                ?.ActiveUsers
                .Where(x => x.Connections.Equals(connectionId))
                .FirstOrDefault() ?? throw new Exception();

        public LobbyActiveUser GetActiveUserFromMeeting(ActiveMeeting activeMeeting, Guid userId) =>
            activeMeeting.ActiveUsers.FirstOrDefault(x => x.User.Id.Equals(userId))
            ?? throw new Exception();

        public LobbyActiveUser GetActiveUserByConnectionId(string connectionId)
        {
            foreach (var activeMeeting in ActiveMeetings)
            {
                var user = activeMeeting.ActiveUsers.FirstOrDefault(
                    u => u.Connections.Any(c => c.ConnectionId == connectionId)
                );
                if (user != null)
                {
                    return user;
                }
            }
            throw new Exception();
        }

        public ActiveMeeting GetActiveMeetingByConnectionId(string connectionId)
        {
            throw new Exception();
        }

        public void AddConnectionToActiveUser(string connectionId, LobbyActiveUser activeUser) =>
            activeUser.AddConnection(connectionId);

        public void RemoveConnectionFromActiveUser(
            string connectionId,
            LobbyActiveUser activeUser
        ) => activeUser.RemoveConnection(connectionId);

        public async Task AddActiveUserToMeeting(Guid userId, ActiveMeeting activeMeeting)
        {
            var user = await _userService.GetUserById(userId);
            activeMeeting.ActiveUsers.Add(new LobbyActiveUser(user));
        }

        public void RemoveUserFromMeeting(LobbyActiveUser user, string connectionId)
        {
            var meeting = GetActiveMeetingByConnectionId(connectionId);
            meeting.ActiveUsers.Remove(user);
        }
    }
}
