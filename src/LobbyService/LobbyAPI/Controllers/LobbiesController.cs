using Domain.Entities;
using Infrastructure.Repository;
using LobbyAPI.Controllers.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace LobbyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LobbiesController(ILobbyRepository lobbyRepository) : ControllerBase
    {
        private readonly ILobbyRepository _lobbyRepository = lobbyRepository;

        [HttpGet]
        public async Task<List<LobbyDto>> GetAllLobbies()
        {
            var lobbies = _lobbyRepository.GetAll();
            List<LobbyDto> lobbyDtos = [.. lobbies.Select(x => new LobbyDto(x))];
            return lobbyDtos;
        }

        [HttpGet("{id}")]
        public async Task<LobbyDto> Get(Guid id)
        {
            var lobby = await _lobbyRepository.GetByIdAsync(id);
            return new LobbyDto(lobby!);
        }

        [HttpPost]
        public async Task<LobbyDto> Create([FromBody] SaveLobbyDto saveLobbyDto)
        {
            var lobby = await _lobbyRepository.CreateAsync(
                new Lobby() { Name = saveLobbyDto.Name, AdminId = saveLobbyDto.AdminId }
            );
            LobbyDto lobbyDto = new(lobby);
            return lobbyDto;
        }

        [HttpPut("{id}")]
        public async Task<LobbyDto> Update([FromBody] SaveLobbyDto saveLobbyDto, Guid id)
        {
            var lobby = await _lobbyRepository.GetByIdAsync(id);
            lobby!.Name = saveLobbyDto.Name;
            await _lobbyRepository.UpdateAsync(lobby);
            LobbyDto lobbyDto = new(lobby);
            return lobbyDto;
        }

        [HttpDelete("{id}")]
        public async Task<Guid> Delete(Guid id)
        {
            await _lobbyRepository.DeleteAsync(id);
            return id;
        }

        [HttpGet("search")]
        public async Task<List<LobbyDto>> SearchLobby([FromQuery] string lobbyName)
        {
            IQueryable<Lobby> lobbies = _lobbyRepository.SearchByName(lobbyName);
            List<LobbyDto> lobbyDtos = lobbies.Select(x => new LobbyDto(x)).ToList();
            return lobbyDtos;
        }
    }
}
