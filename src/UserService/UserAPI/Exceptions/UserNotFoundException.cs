namespace UserAPI.Exceptions;

public class UserNotFoundException(string message, ErrorCode code) : CustomException(message, code)
{
}
