using Newtonsoft.Json;

namespace LobbyAPI.Controllers.Dtos;

[JsonObject]
public record SaveLobbyDto
{
    public required string Name { get; set; }
    public double MinimalRating { get; set; }
    public int MoviesPerUser { get; set; }
    public bool WithCoefficient { get; set; }
}
