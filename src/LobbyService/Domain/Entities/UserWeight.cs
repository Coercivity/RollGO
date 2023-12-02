namespace Domain.Entities
{
    public record UserWeight : EntityBase
    {
        public required User User { get; set; }
        public required Lobby Lobby { get; set; }
    }
}
