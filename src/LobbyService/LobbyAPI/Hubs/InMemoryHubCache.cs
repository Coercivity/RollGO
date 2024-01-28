using LobbyAPI.Hubs.Models;

namespace LobbyAPI.Hubs;

public class InMemoryHubCache
{
    public HashSet<ActiveMeeting> ActiveMeetings { get; set; } = [];
}
