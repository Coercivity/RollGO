using System.Net;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using UserAPI.Controllers.Dtos;
using UserAPI.Services;

namespace UserAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController(ITokenService tokenService, IUserService userService) : ControllerBase
{
    private ITokenService _tokenService = tokenService;
    private IUserService _userService = userService;

    [HttpPost]
    public async Task<ActionResult<SuccessLoginDto>> Register([FromBody] RegisterDto dto)
    {
        var isUserExist = await _userService.UserExists(dto);
        if (isUserExist) {
            return Conflict(new {message= "User already exists"});
        }

        var user = await _userService.CreateUser(dto);
        var tokenPair = await _tokenService.GetTokenPair(user);

        return new SuccessLoginDto(user, tokenPair);
    }

    [HttpPost]
    public async Task<ActionResult<SuccessLoginDto>> Login([FromBody] LoginDto dto)
    {
        var isUserExist = await _userService.UserExists(dto);
        if (!isUserExist) {
            return NotFound();
        }

        var user = await _userService.CheckPassword(dto);
        if (user == null) {
            return Unauthorized();
        }

        var tokenPair = await _tokenService.GetTokenPair(user);

        return new SuccessLoginDto(user, tokenPair);
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
        
        return await _tokenService.GetTokenPair(user);
    }
}
