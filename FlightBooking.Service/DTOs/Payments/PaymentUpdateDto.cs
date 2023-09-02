namespace FlightBooking.Service.DTOs.Payments;

public class PaymentUpdateDto
{
    public long Id { get; set; }
    public long BookingId { get; set; }
    public decimal Amount { get; set; }
    public DateTime PaymentDate { get; set; }
}
