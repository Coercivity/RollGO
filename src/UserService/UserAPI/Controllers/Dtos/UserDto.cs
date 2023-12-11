using Domain.Entities;

namespace UserAPI.Controllers.Dtos;

[Serializable]
public record UserDto
{
    public UserDto(User user)
    {
        Id = user.Id;
        UserName = user.UserName;
    }

    public Guid Id { get; set; }
    public string UserName { get; set; }
}
