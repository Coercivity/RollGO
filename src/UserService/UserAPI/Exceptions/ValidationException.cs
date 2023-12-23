namespace UserAPI.Exceptions;

public class ValidationException(string message, ErrorCode code) : CustomException(message, code) { }
