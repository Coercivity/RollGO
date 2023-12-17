namespace Domain.Entities
{
    public record Meeting : EntityBase
    {
        public Lobby Lobby { get; set; } = null!;
        public User? Winner { get; set; } = null;
        public bool? IsActive { get; set; }

    }
}
