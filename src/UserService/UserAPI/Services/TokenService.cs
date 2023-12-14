using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Domain.Entities;
using Domain.Repositories;
using Microsoft.IdentityModel.Tokens;
using UserAPI.DTOs;

namespace UserAPI.Services;

public class TokenService(IUserSessionRepository userSessionRepository, IConfiguration configuration) : ITokenService
{
    private readonly IUserSessionRepository _userSessionRepository = userSessionRepository;
    private readonly IConfiguration _config = configuration;
    public async Task<bool> ValidateDeleteTokenPair(TokenPair tokenPair)
    {
        var userId = GetTokenClaim(tokenPair.AccessToken, ClaimTypes.NameIdentifier);
        var sessions = await _userSessionRepository.GetUserSessionsByUserIdAsync(Guid.Parse(userId));
        Guid? idToDelete = null;
        foreach (var session in sessions)
        {
            if (session.AccessToken == tokenPair.AccessToken && session.RefreshToken == tokenPair.RefreshToken)
            {
                idToDelete = session.Id;
            }
        }
        if (idToDelete == null)
        {
            return false;
        }
        return (await _userSessionRepository.DeleteAsync((Guid)idToDelete)) != null;
    }

    public async Task<TokenPair> GetTokenPair(UserDto user)
    {
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
        var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
        var claims = new[]
           {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
            };
        var accessToken = new JwtSecurityToken(claims: claims, expires: DateTime.UtcNow.AddMinutes(15), signingCredentials: credentials).ToString();
        var refreshToken = new JwtSecurityToken(expires: DateTime.UtcNow.AddDays(30), signingCredentials: credentials).ToString();

        var session = await _userSessionRepository.CreateAsync(new UserSession()
        {
            UserId = user.Id,
            AccessToken = accessToken,
            RefreshToken = refreshToken
        });

        return new TokenPair()
        {
            AccessToken = session.AccessToken,
            RefreshToken = session.RefreshToken,
        };
    }

    public string? GetTokenClaim(string token, string claimName)
    {
        var securityToken = (JwtSecurityToken)new JwtSecurityTokenHandler().ReadToken(token);
        return securityToken.Claims.FirstOrDefault(c => c.Type == claimName)?.Value;
    }
}
