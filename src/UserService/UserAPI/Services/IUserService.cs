using UserAPI.DTOs;

namespace UserAPI.Services;

public interface IUserService
{
    public Task<UserDto> CreateUser(CreateUserRequestDto dto);

    public Task<UserDto> UpdateUser(UserDto dto);

    public Task<Guid> DeleteUser(Guid id);

    public Task<UserDto> CheckPassword(LoginRequestDto dto);

    public Task<UserDto> GetUser(Guid id);
}
