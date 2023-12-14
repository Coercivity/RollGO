using Domain.Entities;

namespace UserAPI.DTOs;

[Serializable]
public record UserDto
{
    public UserDto(User user)
    {
        Id = user.Id;
        Username = user.Username;
        Email = user.Email;
    }

    public Guid Id { get; set; }
    public string Username { get; set; }
    public string Email {get; set;}
}
