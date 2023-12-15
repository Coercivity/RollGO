namespace UserAPI.DTOs;

[Serializable]
public record UserDto
{
    public Guid Id { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
}
