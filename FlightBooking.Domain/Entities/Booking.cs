using FlightBooking.Domain.Commons;

namespace FlightBooking.Domain.Entities;

public class Booking : Auditable
{
    public int NumberOfTickets { get; set; }
    public decimal TotalPrice { get; set; }
    
    public long UserId { get; set; }
    public User User { get; set; }

    public long FlightId { get; set; }
    public Flight Flight { get; set; }
}
