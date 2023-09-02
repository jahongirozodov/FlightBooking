namespace FlightBooking.Service.Exceptions;

public class IncorrectException: Exception
{
    public IncorrectException(string message) : base(message)
    {
        
    }

    public IncorrectException(string message,Exception exception) : base(message,exception)
    {

    }
}
