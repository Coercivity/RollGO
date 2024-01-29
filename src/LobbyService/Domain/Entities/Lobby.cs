namespace Domain.Entities;

public record Lobby : EntityBase
{
    public required string Name { get; set; }

    public required Guid AdminId { get; set; }

    public List<UserWeight>? UserWeights { get; set; }

    public List<Meeting>? Meetings { get; set; }

    public List<LobbyUser>? LobbyUsers { get; set; }

    public double MinimalRating { get; set; } = 0.0;

    public int MoviesPerUser { get; set; } = 1;

    public bool WithCoefficient { get; set; } = false;
}
