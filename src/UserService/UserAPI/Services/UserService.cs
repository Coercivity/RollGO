using Domain.Entities;
using UserAPI.Controllers.Dtos;

namespace UserAPI.Services;

public class UserService : IUserService
{
    public Task<User> CreateUser(RegisterDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<Guid> DeleteUser(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<User> UpdateUser(UserDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UserExists(RegisterDto dto)
    {
        throw new NotImplementedException();
    }
}
