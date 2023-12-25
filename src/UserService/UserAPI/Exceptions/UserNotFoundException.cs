namespace UserAPI.Exceptions;

public class UserNotFoundException(Error error) : CustomException(error)
{ }
