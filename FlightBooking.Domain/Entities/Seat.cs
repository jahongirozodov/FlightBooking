using FlightBooking.Domain.Commons;

namespace FlightBooking.Domain.Entities;

public class Seat : Auditable
{
    public string Seats { get; set; }
    public bool IsAvailable { get; set; }

    public long FlightId { get; set; }
    public Flight Flight { get; set; }
    
}



