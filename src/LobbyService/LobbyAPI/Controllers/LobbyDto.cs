using Domain.Entities;

namespace LobbyAPI.Controllers
{
    internal class LobbyDto(Lobby lobby)
    {
        public Guid Id { get; set; } = lobby.Id;
        public string Name { get; set; } = lobby.Name;
    }
}