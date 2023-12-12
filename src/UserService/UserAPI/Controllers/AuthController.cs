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
    public async Task<SuccessLoginDto> Login([FromBody] LoginDto dto)
    {
        throw new NotImplementedException();
    }

    [HttpPost]
    public async Task<TokenPair> RefreshToken([FromBody] TokenPair tokenPair)
    {
        throw new NotImplementedException();
    }
}
