using UserAPI.DTOs;

namespace UserAPI.Services;

public interface ITokenService
{
    public Task<bool> ValidateDeleteTokenPair(TokenPair tokenPair);

    public Task<TokenPair> GetTokenPair(UserDto user);

    public string? GetTokenClaim(string token, string claimName);
}
