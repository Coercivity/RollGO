namespace Domain.Entities
{
    public abstract record Entity
    {
        public Guid Id { get; set; }
    }
}
