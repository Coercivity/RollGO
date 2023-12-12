using Domain.Entities;

namespace UserAPI.Controllers.Dtos;

[Serializable]
public record SuccessLoginDto(User User, TokenPair TokenPair)
{    
    public User User { get; init; } = User;

    public string AccessToken { get; init; } = TokenPair.AccessToken;

    public string RefreshToken { get; init; } = TokenPair.RefreshToken;
}
