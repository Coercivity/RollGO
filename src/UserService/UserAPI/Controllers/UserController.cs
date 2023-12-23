using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UserAPI.DTOs;
using UserAPI.Services;

namespace UserAPI.Controllers;

[Authorize]
[ApiController]
[Route("api/[controller]")]
public class UserController(IUserService userService) : ControllerBase
{
    private readonly IUserService _userService = userService;

    [HttpGet("${id}")]
    public async Task<ActionResult<UserDto>> GetUser(Guid id)
    {
        var user = await _userService.GetUser(id);
        return Ok(user);
    }

    [HttpPut]
    public async Task<ActionResult<UserDto>> UpdateUser(UserDto dto)
    {
        var user = await _userService.UpdateUser(dto);
        return Ok(user);
    }

    [HttpDelete("${id}")]
    public async Task<ActionResult<Guid>> DeleteUser(Guid id)
    {
        var userId = await _userService.DeleteUser(id);
        return Ok(userId);
    }
}
