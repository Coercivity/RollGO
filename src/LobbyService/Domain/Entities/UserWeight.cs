namespace Domain.Entities
{
    public record UserWeight : EntityBase
    {
        public required Guid UserId { get; set; }

        public required Lobby Lobby { get; set; }
    }
}
