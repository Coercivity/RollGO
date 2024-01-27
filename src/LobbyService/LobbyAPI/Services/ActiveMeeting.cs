using Domain.Entities;
using LobbyAPI.Hubs;
using Newtonsoft.Json;

namespace LobbyAPI.Services
{
    [JsonObject]
    public class ActiveMeeting(Meeting meeting)
    {
        public Meeting Meeting { get; set; } = meeting;
        public HashSet<LobbyActiveUser> ActiveUsers { get; set; } = [];
        public Dictionary<User, EntertainmentEntity> AddedEntertainmentEntities { get; set; } = [];
    }
}
