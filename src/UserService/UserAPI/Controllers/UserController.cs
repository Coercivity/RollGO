using Microsoft.AspNetCore.Mvc;
using UserAPI.DTOs;
using UserAPI.Services;

namespace UserAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController(IUserService userService) : ControllerBase
{
    private IUserService _userService = userService;

    [HttpGet("${id}")]
    public async Task<ActionResult<UserDto>> GetUser(Guid id)
    {
        var user = await _userService.GetUser(id);
        if (user == null) {
            return NotFound();
        }
        return Ok(user);
    }
}
