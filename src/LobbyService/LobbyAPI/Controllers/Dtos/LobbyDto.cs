using Domain.Entities;

namespace LobbyAPI.Controllers.Dtos
{
    [Serializable]
    public record LobbyDto
    {
        public LobbyDto(Lobby lobby)
        {
            Id = lobby.Id;
            Name = lobby.Name;
            CreatedDateTime = lobby.CreatedDateTime;
            LobbySettings = new LobbySettingsDto(lobby.LobbySettings);
        }

        public LobbyDto(Guid id, DateTime createdDateTime, string name)
        {
            CreatedDateTime = createdDateTime;
            Id = id;
            Name = name;
        }

        public Guid Id { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public string Name { get; set; }
        public LobbySettingsDto LobbySettings { get; set; }
    }
}
