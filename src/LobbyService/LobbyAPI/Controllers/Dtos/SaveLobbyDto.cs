using System.Text.Json.Serialization;

namespace LobbyAPI.Controllers.Dtos
{
    [Serializable]
    public record SaveLobbyDto
    {
        public required string Name { get; set; }
        public Guid AdminId { get; internal set; }
    }
}
