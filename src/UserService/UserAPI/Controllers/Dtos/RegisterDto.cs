namespace UserAPI.Controllers.Dtos;

[Serializable]
public record RegisterDto
{
    public required string Username { get; set; }

    public required string Email {get; set;}

    public required string Password{get;set;}
}
