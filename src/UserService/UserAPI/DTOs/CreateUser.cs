namespace UserAPI.DTOs;

[Serializable]
public record CreateUserRequestDto
{
    public required string Username { get; set; }

    public required string Email {get; set;}

    public required string Password{get;set;}
}
