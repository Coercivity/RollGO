using Domain.Entities;
using Infrastructure.Repository;
using Infrastructure.Repository.Implementation;
using LobbyAPI.Controllers.Dtos;
using LobbyAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace LobbyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LobbiesController(ILobbyRepository lobbyRepository, MeetingService meetingService) : ControllerBase
    {
        private readonly ILobbyRepository _lobbyRepository = lobbyRepository;
        private readonly MeetingService _meetingService = meetingService;

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
            Guid adminId = Guid.Parse(HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)!.Value); 
            var lobby = await _lobbyRepository.CreateAsync(
                new Lobby() 
                { 
                    Name = saveLobbyDto.Name, 
                    AdminId = adminId,
                    MinimalRating = saveLobbyDto.MinimalRating,
                    MoviesPerUser = saveLobbyDto.MoviesPerUser,
                    WithCoefficient = saveLobbyDto.WithCoefficient
                }
            );

            LobbyDto lobbyDto = new(lobby);
            var meeting = new Meeting
            {
                Lobby = lobby,
                IsActive = true,
            };
            var activeMeeting = new ActiveMeeting(meeting);
            _meetingService.ActiveMeetings.Add(activeMeeting);

            return lobbyDto;
        }

        [HttpPut("{id}")]
        public async Task<LobbyDto> Update([FromBody] SaveLobbyDto saveLobbyDto, Guid id)
        {
            var lobby = await _lobbyRepository.GetByIdAsync(id);

            lobby!.Name = saveLobbyDto.Name;
            lobby!.MinimalRating = saveLobbyDto.MinimalRating;
            lobby!.MoviesPerUser = saveLobbyDto.MoviesPerUser;
            lobby!.WithCoefficient = saveLobbyDto.WithCoefficient;

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
