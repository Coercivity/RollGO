namespace Domain.Entities
{
    public record User : EntityBase
    {
        public required string UserName { get; set; }
        public string Icon { get; set; }
        public string Email { get; set; }
    }
}
