namespace Domain.Entities
{
    public record EntityBase
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public DateTime CreatedDateTime { get; set; } = DateTime.UtcNow;
    }
}
