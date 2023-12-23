using AutoMapper;
using Domain.Entities;
using Domain.Repositories;
using UserAPI.DTOs;
using UserAPI.Exceptions;

namespace UserAPI.Services;

public class UserService(IUserRepository userRepository, IMapper mapper) : IUserService
{
    private readonly IUserRepository _userRepository = userRepository;
    private readonly IMapper _mapper = mapper;

    public async Task<UserDto> CheckPassword(LoginRequestDto dto)
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
            throw new UserNotFoundException(ErrorCode.WrongUsernameOrPassword);
        }

        var result = BCrypt.Net.BCrypt.Verify(dto.Password, user.Password);
        if (!result)
        {
            throw new UserNotFoundException(ErrorCode.WrongUsernameOrPassword);
        }
        return _mapper.Map<UserDto>(user);
    }

    public async Task<UserDto> CreateUser(CreateUserRequestDto dto)
    {
        var usernameExists = await UsernameExists(dto.Username);
        if (usernameExists)
        {
            throw new UserConflictException(ErrorCode.UsernameExists);
        }
        var emailExists = await EmailExists(dto.Email);
        if (emailExists)
        {
            throw new UserConflictException(ErrorCode.EmailExists);
        }
        var passwordHash = BCrypt.Net.BCrypt.HashPassword(dto.Password);
        var user = await _userRepository.CreateAsync(new User()
        {
            Username = dto.Username,
            Email = dto.Email,
            Password = passwordHash,
        });
        return _mapper.Map<UserDto>(user);
    }

    public async Task<Guid> DeleteUser(Guid id)
    {
        return await _userRepository.DeleteAsync(id) ?? throw new UserNotFoundException(ErrorCode.UserNotFound);
    }

    public async Task<UserDto> GetUser(Guid id)
    {
        var user = await _userRepository.GetByIdAsync(id) ?? throw new UserNotFoundException(ErrorCode.UserNotFound);
        return _mapper.Map<UserDto>(user);
    }

    public async Task<UserDto> UpdateUser(UserDto dto)
    {
        var user = await _userRepository.UpdateAsync(_mapper.Map<User>(dto)) ?? throw new UserNotFoundException(ErrorCode.UserNotFound);
        return _mapper.Map<UserDto>(user);
    }

    private async Task<bool> EmailExists(string email)
    {
        var user = await _userRepository.GetByEmailAsync(email);
        return user != null;
    }

    private async Task<bool> UsernameExists(string username)
    {
        var user = await _userRepository.GetByUsernameAsync(username);
        return user != null;
    }
}
