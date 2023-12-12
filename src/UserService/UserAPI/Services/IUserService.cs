using Domain.Entities;
using UserAPI.Controllers.Dtos;

namespace UserAPI.Services;

public interface IUserService
{
    public Task<bool> UserExists(RegisterDto dto);

    public Task<bool> UserExists(LoginDto dto);

    public Task<UserDto> CreateUser(RegisterDto dto);

    public Task<UserDto> UpdateUser(UserDto dto);

    public Task<Guid> DeleteUser(Guid id);

    public Task<UserDto> CheckPassword(LoginDto dto);

    public Task<UserDto> GetUser(Guid id);

}
