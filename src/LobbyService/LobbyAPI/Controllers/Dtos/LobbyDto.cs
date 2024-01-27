using Domain.Entities;
using Newtonsoft.Json;

namespace LobbyAPI.Controllers.Dtos
{
    [JsonObject]
    public record LobbyDto
    {
        public LobbyDto(Lobby lobby)
        {
            Id = lobby.Id;
            AdminId = lobby.AdminId;
            Name = lobby.Name;
            CreatedDateTime = lobby.CreatedDateTime;
            MinimalRating = lobby.MinimalRating;
            MoviesPerUser = lobby.MoviesPerUser;
            WithCoefficient = lobby.WithCoefficient;
        }

        public Guid Id { get; set; }
        public Guid AdminId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public string Name { get; set; }
        public double MinimalRating { get; set; } = 0.0;
        public int MoviesPerUser { get; set; } = 1;
        public bool WithCoefficient { get; set; } = false;
    }
}
