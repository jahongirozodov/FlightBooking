namespace FlightBooking.Service.DTOs.Bookings;
public class BookingUpdateDto
{
    public long Id { get; set; }
    public int NumberOfTickets { get; set; }
    public decimal TotalPrice { get; set; }

    public long UserId { get; set; }
    public long FlightId { get; set; }
}
