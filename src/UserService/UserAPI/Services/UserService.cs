using Domain.Entities;
using UserAPI.Controllers.Dtos;

namespace UserAPI.Services;

public class UserService : IUserService
{
    public Task<UserDto> CheckPassword(LoginDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<UserDto> CreateUser(RegisterDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<Guid> DeleteUser(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<UserDto> GetUser(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<UserDto> UpdateUser(UserDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UserExists(RegisterDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UserExists(LoginDto dto)
    {
        throw new NotImplementedException();
    }
}
