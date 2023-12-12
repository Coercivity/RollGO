using Domain.Entities;

namespace UserAPI.Services;

public class TokenService : ITokenService
{
    public Task<bool> ValidateTokenPair(TokenPair tokenPair)
    {
        throw new NotImplementedException();
    }

    public TokenPair GetTokenPair()
    {
        throw new NotImplementedException();
    }
}
