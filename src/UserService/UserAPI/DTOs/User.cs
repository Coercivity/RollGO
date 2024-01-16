using System.ComponentModel.DataAnnotations;

namespace UserAPI.DTOs;

[Serializable]
public record UserDto
{
    public Guid Id { get; set; }
    public string Username { get; set; }

    [EmailAddress(ErrorMessage = "Invalid email format")]
    public string Email { get; set; }
    public string? Icon { get; set; }

    [StringLength(100, MinimumLength = 8, ErrorMessage = "The Password must be at least 8 characters")]
    [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*\W).+$",
        ErrorMessage = "The Password must contain at least one lowercase letter, one uppercase letter, one digit, and one special character")]
    public string? Password { get; set; }
    public string? CurrentPassword { get; set; }
}
