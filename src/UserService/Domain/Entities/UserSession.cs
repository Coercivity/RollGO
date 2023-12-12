namespace Domain.Entities;

public record UserSession : EntityBase
{
    public required Guid UserId {get; set;}

    public required User User {get; set;}

    public required string AccessToken {get; set;}
    
    public required string RefreshToken {get; set;}

    public string? Platform {get; set;}

    public string? UserAgent {get; set;}

}
