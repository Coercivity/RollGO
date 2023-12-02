namespace Domain.Entities
{
    public record Lobby : EntityBase
    {
        public required string Name { get; set; }
        public required User Admin { get; set; }
        public List<UserWeight>? UserWeights { get; set; }
        public List<Meeting>? Meetings { get; set; }

    }
}