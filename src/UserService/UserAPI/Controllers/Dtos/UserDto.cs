using Domain.Entities;

namespace UserAPI.Controllers.Dtos;

[Serializable]
public record UserDto
{
    public UserDto(User user)
    {
        Id = user.Id;
        Username = user.Username;
    }

    public Guid Id { get; set; }
    public string Username { get; set; }
}
