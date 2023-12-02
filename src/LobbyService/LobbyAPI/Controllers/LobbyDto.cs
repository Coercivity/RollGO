using Domain.Entities;

namespace LobbyAPI.Controllers
{
    public record LobbyDto(Lobby lobby)
    {
        public Guid Id { get; set; } = lobby.Id;
        public string Name { get; set; } = lobby.Name;
    }
}