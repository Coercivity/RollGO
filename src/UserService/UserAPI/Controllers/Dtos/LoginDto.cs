using Domain.Entities;

namespace UserAPI.Controllers.Dtos;

[Serializable]
public record LoginDto
{
    public string? Username { get; set; }

    public string? Email {get; set;}

    public required string Password{get;set;}
}
