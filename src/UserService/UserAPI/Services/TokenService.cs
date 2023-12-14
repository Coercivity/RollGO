using Domain.Entities;
using UserAPI.DTOs;

namespace UserAPI.Services;

public class TokenService : ITokenService
{
    public Task<bool> ValidateTokenPair(TokenPair tokenPair)
    {
        throw new NotImplementedException();
    }

    public Task<TokenPair> GetTokenPair(UserDto user)
    {
        throw new NotImplementedException();
    }

    public Guid GetUserId(string accessToken)
    {
        throw new NotImplementedException();
    }
}
