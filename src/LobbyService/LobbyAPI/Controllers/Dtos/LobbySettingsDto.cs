using Domain.Entities;
using System.Text.Json.Serialization;

namespace LobbyAPI.Controllers.Dtos;

[Serializable]
public record LobbySettingsDto
{
    public LobbySettingsDto(LobbySettings lobbySettings) {
        MinimalRating = lobbySettings.MinimalRating;
        MoviesPerUser = lobbySettings.MoviesPerUser;
        WithKoefficient = lobbySettings.WithKoefficient;
    }

    [JsonConstructor]
    public LobbySettingsDto(float minimalRating, int moviesPerUser, bool withKoefficient) {
        MinimalRating = minimalRating;
        MoviesPerUser = moviesPerUser;
        WithKoefficient = withKoefficient;
    }

    public float MinimalRating { get; set; }
    public int MoviesPerUser { get; set; }
    public bool WithKoefficient { get; set; }
}