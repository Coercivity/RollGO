namespace LobbyAPI.Services;

public class InMemoryHubCache
{
   public HashSet<ActiveMeeting> ActiveMeeting { get; set; } = [];
}
