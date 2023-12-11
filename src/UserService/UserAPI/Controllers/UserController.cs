using Infrastructure.Repository;
using Microsoft.AspNetCore.Mvc;
using UserAPI.Controllers.Dtos;

namespace UserAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController(IUserRepository userRepository) : ControllerBase
{
    private readonly IUserRepository _userRepository = userRepository;

    [HttpPut("{id}")]
    public async Task<UserDto> UpdateUserName([FromBody] string userName, Guid id)
    {
        return new UserDto(await _userRepository.UpdateUserName(id, userName));
    }
}
