namespace FlightBooking.Service.Exceptions;

public class NotFoundException : Exception
{
    public int StatusCode = 404;
    public NotFoundException(string Message):base(Message)
    {
        
    }

    public NotFoundException(string Message,Exception exception) : base(Message,exception)
    {

    }
}
