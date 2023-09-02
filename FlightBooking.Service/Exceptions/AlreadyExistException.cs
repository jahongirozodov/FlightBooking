namespace FlightBooking.Service.Exceptions;

public class AlreadyExistException : Exception
{
    public int StatusCode = 403;
    public AlreadyExistException(string Message) : base(Message)
    {

    }

    public AlreadyExistException(string Message, Exception exception) : base(Message, exception)
    {

    }
}