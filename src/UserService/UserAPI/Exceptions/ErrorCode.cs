namespace UserAPI.Exceptions;

[Serializable]
public record Error
{
    public string Code { get; init; } = null!;
    public string Description { get; init; } = null!;
}

public class ErrorCode
{
    public static Error UsernameExists => new() { Code = "UsernameExists", Description = "User with provided username exists" };
    public static Error EmailExists => new() { Code = "EmailExists", Description = "Email with provided email exists" };
    public static Error WrongUsernameOrPassword => new() { Code = "WrongUsernameOrPassword", Description = "Can not login. Incorrect username or password" };
    public static Error NotValidUsername => new() { Code = "NotValidUsername", Description = "Username is not valid" };
    public static Error NotValidEmail => new() { Code = "NotValidEmail", Description = "Email is not valid" };
    public static Error NotValidPassword => new() { Code = "NotValidPassword", Description = "Password is not valid" };
}
