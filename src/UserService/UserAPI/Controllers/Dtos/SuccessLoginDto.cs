using Domain.Entities;

namespace UserAPI.Controllers.Dtos;

[Serializable]
public record SuccessLoginDto
{
    SuccessLoginDto(User user, string accessToken, string refreshToken)
    {
        User = user;
        AccessToken = accessToken;
        RefreshToken = refreshToken;
    }
    
    public required User User { get; set; }

    public required string AccessToken {get; set;}

    public required string RefreshToken{get;set;}
}
