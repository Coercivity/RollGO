using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using UserAPI.Controllers.Dtos;

namespace UserAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    [HttpPost]
    public async Task<SuccessLoginDto> Register([FromBody] RegisterDto dto)
    {
        throw new NotImplementedException();
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
