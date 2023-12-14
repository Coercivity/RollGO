using Domain.Entities;
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

    [HttpPost]
    public async Task<ActionResult<LoginResponseDto>> Register([FromBody] CreateUserRequestDto dto)
    {
        var isUserExist = await _userService.UserExists(dto);
        if (isUserExist) {
            return Conflict(new {message= "User already exists"});
        }

        var user = await _userService.CreateUser(dto);
        var tokenPair = await _tokenService.GetTokenPair(user);

        return Ok(new LoginResponseDto(user, tokenPair));
    }

    [HttpPost]
    public async Task<ActionResult<LoginResponseDto>> Login([FromBody] LoginRequestDto dto)
    {
        var user = await _userService.CheckPassword(dto);
        if (user == null) {
            return Unauthorized();
        }

        var tokenPair = await _tokenService.GetTokenPair(user);

        return Ok(new LoginResponseDto(user, tokenPair));
    }

    [HttpPost]
    public async Task<ActionResult<TokenPair>> RefreshToken([FromBody] TokenPair tokenPair)
    {
        var isValidTokenPair = await _tokenService.ValidateTokenPair(tokenPair);
        if (!isValidTokenPair) {
            return Forbid();
        }
        
        var userId = _tokenService.GetUserId(tokenPair.AccessToken);
        var user = await _userService.GetUser(userId);

        return Ok(await _tokenService.GetTokenPair(user));
    }
}
