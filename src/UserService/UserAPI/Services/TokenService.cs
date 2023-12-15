using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Domain.Entities;
using Domain.Repositories;
using Microsoft.IdentityModel.Tokens;
using UserAPI.DTOs;

namespace UserAPI.Services;

public class TokenService(
    IUserSessionRepository userSessionRepository,
    IConfiguration configuration
) : ITokenService
{
    private readonly IUserSessionRepository _userSessionRepository = userSessionRepository;
    private readonly IConfiguration _config = configuration;

    public async Task<bool> ValidateDeleteTokenPair(TokenPair tokenPair)
    {
        if (!ValidateRefreshToken(tokenPair.RefreshToken)){
            return false;
        }

        Guid? idToDelete = null;
        var refreshTokenId = Guid.Parse(GetTokenClaim(tokenPair.RefreshToken, ClaimTypes.NameIdentifier));

        var userId = Guid.Parse(GetTokenClaim(tokenPair.AccessToken, ClaimTypes.NameIdentifier));
        var sessions = await _userSessionRepository.GetUserSessionsByUserIdAsync(userId);
        foreach (var session in sessions)
        {
            if (session.RefreshTokenId == refreshTokenId)
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
        var accessToken = GenerateAccessToken(user);
        var (refreshToken, refreshTokenId) = GenerateRefreshToken();
        var session = await _userSessionRepository.CreateAsync(
            new UserSession()
            {
                UserId = user.Id,
                RefreshTokenId = refreshTokenId
            }
        );

        if (session == null)
        {
            return null;
        }
        return new TokenPair()
        {
            AccessToken = accessToken,
            RefreshToken = refreshToken,
        };
    }

    public string? GetTokenClaim(string token, string claimName)
    {
        var securityToken = (JwtSecurityToken)new JwtSecurityTokenHandler().ReadToken(token);
        return securityToken.Claims.FirstOrDefault(c => c.Type == claimName)?.Value;
    }

    private (string, Guid) GenerateRefreshToken()
    {
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
        var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
        var refreshTokenId = Guid.NewGuid();
        var refreshClaims = new[] { new Claim(ClaimTypes.NameIdentifier, refreshTokenId.ToString()), };
        var refreshToken = new JwtSecurityToken(
            _config["Jwt:Issuer"],
            _config["Jwt:Issuer"],
            claims: refreshClaims,
            expires: DateTime.UtcNow.AddDays(30),
            signingCredentials: credentials
        );

        return (new JwtSecurityTokenHandler().WriteToken(refreshToken), refreshTokenId);
    }

    private string GenerateAccessToken(UserDto user)
    {
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
        var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
        var accessClaims = new[] { new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()), };
        var accessToken = new JwtSecurityToken(
            _config["Jwt:Issuer"],
            _config["Jwt:Issuer"],
            claims: accessClaims,
            expires: DateTime.UtcNow.AddMinutes(15),
            signingCredentials: credentials
        );
        return new JwtSecurityTokenHandler().WriteToken(accessToken);
    }

    private bool ValidateRefreshToken(string tokenString)
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        var token = tokenHandler.ReadToken(tokenString);
        return token.ValidTo > DateTime.Now;
    }
}
