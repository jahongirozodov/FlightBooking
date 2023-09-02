using FlightBooking.Domain.Commons;

namespace FlightBooking.Domain.Entities;

public class Ticket : Auditable
{
    public decimal Price { get; set; }
 
    public long FlightId { get; set; }
    public Flight Flight { get; set; }

    public long UserId { get; set; }
    public User User { get; set; }
}



