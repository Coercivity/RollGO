
using UserAPI.Services;

namespace UserAPI.DTOs;

[Serializable]
public record LoginRequestDto
{
    public string? Username { get; set; }

    public string? Email { get; set; }

    public required string Password { get; set; }
}


[Serializable]
public record LoginResponseDto(UserDto User, string AccessToken, string RefreshToken)
{
    public UserDto User { get; init; } = User;

    public string AccessToken { get; init; } = AccessToken;

    public string RefreshToken { get; init; } = RefreshToken;
}
