using AutoMapper;
using Domain.Entities;
using Domain.Repositories;
using Microsoft.IdentityModel.Tokens;
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
        await UsernameExists(dto.Username);

        await EmailExists(dto.Email);

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
        var user = await _userRepository.GetByIdAsync(dto.Id) ?? throw new UserNotFoundException(ErrorCode.UserNotFound);

        if (!dto.Password.IsNullOrEmpty())
        {
            dto.Password = BCrypt.Net.BCrypt.HashPassword(dto.Password);

            if (!BCrypt.Net.BCrypt.Verify(dto.CurrentPassword, user.Password))
            {
                throw new UserConflictException(ErrorCode.WrongPassword);
            }
        }

        if (dto.Email != user.Email)
        {
            await EmailExists(dto.Email);
        }

        if (dto.Username != user.Username)
        {
            await UsernameExists(dto.Username);
        }

        var updatedUser = await _userRepository.UpdateAsync(_mapper.Map<User>(dto)) ?? throw new UserNotFoundException(ErrorCode.UserNotFound);
        updatedUser.Password = null;

        return _mapper.Map<UserDto>(updatedUser);
    }

    private async Task EmailExists(string email)
    {
        var user = await _userRepository.GetByEmailAsync(email);

        if (user != null)
        {
            throw new UserConflictException(ErrorCode.EmailExists);
        }
    }

    private async Task UsernameExists(string username)
    {
        var user = await _userRepository.GetByUsernameAsync(username);

        if (user != null)
        {
            throw new UserConflictException(ErrorCode.UsernameExists);
        }
    }

}
