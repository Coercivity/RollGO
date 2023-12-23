namespace UserAPI.Exceptions;

public class ValidationException(Error error) : CustomException(error)
{ }