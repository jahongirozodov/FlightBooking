using FlightBooking.Domain.Commons;
using FlightBooking.Domain.Entities;

namespace FlightBooking.Service.DTOs.Payments;

public class PaymentCreationDto
{
    public long BookingId { get; set; }
    public decimal Amount { get; set; }
    public DateTime PaymentDate { get; set; }
}
