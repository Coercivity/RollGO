using Microsoft.AspNetCore.Mvc;
using UserAPI.DTOs;

namespace UserAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    [HttpPut]
    public async Task<UserDto> UpdateUser([FromBody] UserDto dto)
    {
        throw new NotImplementedException();
    }
}
