using Domain.Entities;
using LobbyAPI.Hubs;

namespace LobbyAPI.Services
{
    public class ActiveMeeting
    {
        public required Meeting Meeting { get; set; }
        public HashSet<LobbyUser> Users { get; set; } = [];
    }
}
