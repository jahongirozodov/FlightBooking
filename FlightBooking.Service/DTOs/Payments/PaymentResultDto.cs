using FlightBooking.Service.DTOs.Bookings;

namespace FlightBooking.Service.DTOs.Payments;

public class PaymentResultDto
{
    public long Id { get; set; }
    public BookingResultDto Booking { get; set; }
    public decimal Amount { get; set; }
    public DateTime PaymentDate { get; set; }
}
