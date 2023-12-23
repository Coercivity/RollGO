namespace Domain.Entities;

public record User : EntityBase
{
    public required string Username { get; set; }
    public required string Email { get; set; }
    public string? Password { get; set; }
    public string? Icon { get; set; }
    public List<UserSession> UserSessions { get; set; } = [];
}
