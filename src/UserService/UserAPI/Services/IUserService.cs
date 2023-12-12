using Domain.Entities;
using UserAPI.Controllers.Dtos;

namespace UserAPI.Services;

public interface IUserService
{
    public Task<bool> UserExists(RegisterDto dto);

    public Task<User> CreateUser(RegisterDto dto);

    public Task<User> UpdateUser(UserDto dto);

    public Task<Guid> DeleteUser(Guid id);

}
