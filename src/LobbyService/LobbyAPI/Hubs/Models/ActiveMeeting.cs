using Domain.Entities;
using Newtonsoft.Json;

namespace LobbyAPI.Hubs.Models;

[JsonObject]
public class ActiveMeeting(Meeting meeting)
{
    public Meeting Meeting { get; set; } = meeting;
    public HashSet<LobbyActiveUser> ActiveUsers { get; set; } = [];
    public Dictionary<User, List<EntertainmentEntity>> AddedEntertainmentEntities { get; set; } = [];
}
