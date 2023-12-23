namespace UserAPI.Exceptions;

public class CustomException(string message, ErrorCode code) : Exception(message)
{
    public ErrorCode Code = code;
}
