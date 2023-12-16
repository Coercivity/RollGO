using AutoMapper;
using Domain.Entities;
using Domain.Repositories;
using UserAPI.DTOs;

namespace UserAPI.Services;

public class UserService(IUserRepository userRepository, IMapper mapper) : IUserService
{
    private readonly IUserRepository _userRepository = userRepository;
    private readonly IMapper _mapper = mapper;

    public async Task<UserDto?> CheckPassword(LoginRequestDto dto)
    {
        User? user = null;
        if (dto.Username != null)
        {
            user = await _userRepository.GetByUsernameAsync(dto.Username);
        }
        if (dto.Email != null)
        {
            user = await _userRepository.GetByEmailAsync(dto.Email);
        }
        if (user == null)
        {
            return null;
        }
        
        var result = BCrypt.Net.BCrypt.Verify(dto.Password, user.Password);
        return result ? _mapper.Map<UserDto>(user) : null;
    }

    public async Task<UserDto> CreateUser(CreateUserRequestDto dto)
    {
        var passwordHash = BCrypt.Net.BCrypt.HashPassword(dto.Password);
        var user = await _userRepository.CreateAsync(new User()
        {
            Username = dto.Username,
            Email = dto.Email,
            Password = passwordHash,
        });
        return _mapper.Map<UserDto>(user);
    }

    public Task<Guid> DeleteUser(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<UserDto> GetUser(Guid id)
    {
        var user = await _userRepository.GetByIdAsync(id);
        return _mapper.Map<UserDto>(user);
    }

    public Task<UserDto> UpdateUser(UserDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UserExists(CreateUserRequestDto dto)
    {
        var emailUser = _userRepository.GetByEmailAsync(dto.Email);
        var nameUser = _userRepository.GetByUsernameAsync(dto.Username);
        Task.WaitAll([emailUser, nameUser]);

        return Task.FromResult(emailUser.Result != null || nameUser.Result != null);
    }
}
