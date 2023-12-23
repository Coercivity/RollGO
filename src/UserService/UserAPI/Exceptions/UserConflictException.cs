namespace UserAPI.Exceptions;

public class UserConflictException(string message, ErrorCode code) : CustomException(message, code)
{ }
