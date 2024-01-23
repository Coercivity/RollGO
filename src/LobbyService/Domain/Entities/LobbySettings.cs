namespace Domain.Entities;

public record LobbySettings : EntityBase
{
    public Lobby Lobby { get; set; }

    public Guid LobbyId { get; set; }

    public float MinimalRating { get; set; }

    public int MoviesPerUser { get; set; }

    public bool WithKoefficient { get; set; }
}