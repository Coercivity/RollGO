namespace Domain.Entities;

public record UserSession : EntityBase
{
    public required Guid UserId { get; set; }

    public virtual User User { get; private set; }

    public required string RefreshTokenHash { get; set; }

    public string? Platform { get; set; }

    public string? UserAgent { get; set; }

}
