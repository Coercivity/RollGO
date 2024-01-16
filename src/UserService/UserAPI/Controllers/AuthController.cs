using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using UserAPI.DTOs;
using UserAPI.Services;

namespace UserAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController(ITokenService tokenService, IUserService userService) : ControllerBase
{
    private readonly ITokenService _tokenService = tokenService;
    private readonly IUserService _userService = userService;

    [HttpPost("Register")]
    public async Task<ActionResult<LoginResponseDto>> Register([FromBody] CreateUserRequestDto dto)
    {
        var user = await _userService.CreateUser(dto);

        var tokenPair = await _tokenService.GetTokenPair(user);

        return Ok(new LoginResponseDto(user, tokenPair.AccessToken, tokenPair.RefreshToken));
    }

    [HttpPost("Login")]
    public async Task<ActionResult<LoginResponseDto>> Login([FromBody] LoginRequestDto dto)
    {
        var user = await _userService.CheckPassword(dto);

        var tokenPair = await _tokenService.GetTokenPair(user);

        return Ok(new LoginResponseDto(user, tokenPair.AccessToken, tokenPair.RefreshToken));
    }

    [HttpPost("RefreshToken")]
    public async Task<ActionResult<TokenPair>> RefreshToken([FromBody] TokenPair tokenPair)
    {
        var isValidTokenPair = await _tokenService.ValidateAndDeleteTokenPair(tokenPair);
        
        var userId = _tokenService.GetTokenClaim(tokenPair.AccessToken, ClaimTypes.NameIdentifier);

        var user = await _userService.GetUser(Guid.Parse(userId!));

        if (!isValidTokenPair || user == null)
        {
            return Forbid();
        }

        var result = await _tokenService.GetTokenPair(user);

        return Ok(result);
    }
}
