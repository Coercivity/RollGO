namespace Domain.Entities
{
    public record UserSession : EntityBase
    {
        public required string User {get; set;}

        public required string AccessToken {get; set;}
        
        public required string RefreshToken {get; set;}

        public string? Platform {get; set;}

        public string? UserAgent {get; set;}

    }
}
