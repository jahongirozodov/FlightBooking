using FlightBooking.Domain.Commons;

namespace FlightBooking.Domain.Entities;

public class Payment : Auditable
{
    public long BookingId { get; set; }
    public Booking Booking { get; set; }

    public decimal Amount { get; set; }
    public DateTime PaymentDate { get; set; }
}