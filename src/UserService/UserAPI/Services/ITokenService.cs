using Domain.Entities;

namespace UserAPI.Services;

public interface ITokenService
{
    public Task<bool> ValidateTokenPair(TokenPair tokenPair);

    public TokenPair GetTokenPair();
}
