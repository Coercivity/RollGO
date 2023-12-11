namespace Domain.Entities;

public record User : EntityBase
{
    public required string Username {get; set;}

    public List<UserSession> UserSessions {get; set;} = [];

}
