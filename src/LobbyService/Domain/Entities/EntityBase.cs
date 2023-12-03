namespace Domain.Entities
{
    public abstract record EntityBase
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime CreatedDateTime { get; set; } = DateTime.UtcNow;
    }
}
