using Infrastructure.Repository;
using Microsoft.AspNetCore.Mvc;

namespace LobbyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LobbiesController(ILobbyRepository lobbyRepository) : ControllerBase
    {
        private readonly ILobbyRepository _lobbyRepository = lobbyRepository;

        [HttpGet]
        public Task<List<int>> GetAllLobbies()
        {
            var lobbies = _lobbyRepository.GetAll();
            lobbies.Select(x => new LobbyDto(x)).ToList();
            return (Task<List<int>>)lobbies;
        }

        [HttpGet("{id}")]
        public async Task<LobbyDto> Get(Guid id)
        {
            var lobby = await _lobbyRepository.GetByIdAsync(id);
            return new LobbyDto(lobby!);
        }

    }


}
