namespace UserAPI.DTOs;

[Serializable]
public record UserDto
{
    public Guid Id { get; set; }
    public string? Username { get; set; }
    public string? Email { get; set; }
    public string? Icon { get; set; }
    public string? Password { get; set; }
    public string? CurrentPassword { get; set; }
}
