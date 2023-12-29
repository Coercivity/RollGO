using System.ComponentModel.DataAnnotations;

namespace UserAPI.DTOs;

[Serializable]
public record CreateUserRequestDto
{
    public required string Username { get; set; }

    [EmailAddress(ErrorMessage = "Invalid email format")]
    public required string Email { get; set; }

    [Required(ErrorMessage = "The Password field is required")]
    [StringLength(100, MinimumLength = 8, ErrorMessage = "The Password must be at least 8 characters")]
    [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*\W).+$",
        ErrorMessage = "The Password must contain at least one lowercase letter, one uppercase letter, one digit, and one special character")]
    public required string Password { get; set; }
}
