namespace Domain.Entities
{
    public record Meeting : EntityBase
    {
        public Lobby Lobby { get; set; } = null!;
        public Guid? WinnerId { get; set; } = null;
        public EntertainmentEntity? WinnerEntity { get; set; } = null;
        public bool? IsActive { get; set; }

    }
}
