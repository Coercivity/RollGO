namespace Domain.Entities
{
    public record User : EntityBase
    {
        public required string UserName { get; set; }
    }
}
