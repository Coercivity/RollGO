namespace UserAPI.Exceptions;

public class UserConflictException(Error error) : CustomException(error)
{ }
