namespace Domain.Entities
{
    public record LobbyUser : EntityBase
    {
        public required Guid UserId { get; set; }

        public required Lobby Lobby { get; set; }
    }
}
