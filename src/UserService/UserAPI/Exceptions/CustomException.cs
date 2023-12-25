namespace UserAPI.Exceptions;

public class CustomException(Error error) : Exception
{
    public Error Error = error;
}
