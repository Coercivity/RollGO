using Domain.Entities;
using UserAPI.DTOs;

namespace UserAPI.Services;

public interface ITokenService
{
    public Task<bool> ValidateTokenPair(TokenPair tokenPair);

    public Task<TokenPair> GetTokenPair(UserDto user);

    public Guid GetUserId(string accessToken);
}
