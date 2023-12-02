namespace Domain.Entities
{
    public abstract record EntityBase
    {
        public required Guid Id { get; set; }

        public required DateTime CreatedDateTime { get; set; }
    }
}
