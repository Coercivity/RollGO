namespace UserAPI.Services;

public record TokenPair
{
    public required string AccessToken { get; set; }

    public required string RefreshToken { get; set; }
}
