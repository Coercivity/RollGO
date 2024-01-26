using Domain.Entities;
using Infrastructure.Repository;
using Infrastructure.Repository.Implementation;
using LobbyAPI.Controllers.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LobbyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LobbiesController(ILobbyRepository lobbyRepository, ILobbySettingsRepository lobbySettingsRepository) : ControllerBase
    {
        private readonly ILobbyRepository _lobbyRepository = lobbyRepository;
        private readonly ILobbySettingsRepository _lobbySettingsRepository = lobbySettingsRepository;

        [HttpGet]
        public async Task<List<LobbyDto>> GetAllLobbies()
        {
            var lobbies = _lobbyRepository.GetAll();
            List<LobbyDto> lobbyDtos = [.. lobbies.Include(x => x.Settings).Select(x => new LobbyDto(x))];
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
            var lobbySettings = await _lobbySettingsRepository.CreateAsync(
              new LobbySettings()
              {
                  Lobby = lobby,
                  MinimalRating = saveLobbyDto.Settings.MinimalRating,
                  MoviesPerUser = saveLobbyDto.Settings.MoviesPerUser,
                  WithKoefficient = saveLobbyDto.Settings.WithKoefficient
              }
            );
            LobbyDto lobbyDto = new(lobby)
            {
                Settings = new LobbySettingsDto(lobbySettings)
            };
            return lobbyDto;
        }

        [HttpPut("{id}")]
        public async Task<LobbyDto> Update([FromBody] SaveLobbyDto saveLobbyDto, Guid id)
        {
            var lobby = await _lobbyRepository.GetByIdAsync(id);
            lobby!.Name = saveLobbyDto.Name;
            await _lobbyRepository.UpdateAsync(lobby);

            var lobbySettings = await _lobbySettingsRepository.GetByIdAsync(lobby.Settings.Id);
            lobbySettings!.MinimalRating = saveLobbyDto.Settings.MinimalRating;
            lobbySettings!.MoviesPerUser = saveLobbyDto.Settings.MoviesPerUser;
            lobbySettings!.WithKoefficient = saveLobbyDto.Settings.WithKoefficient;
            await _lobbySettingsRepository.UpdateAsync(lobbySettings);
            
            LobbyDto lobbyDto = new(lobby)
            {
                Settings = new LobbySettingsDto(lobbySettings)
            };
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
