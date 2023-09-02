using FlightBooking.Service.DTOs.Flights;

namespace FlightBooking.Service.DTOs.Bookings;

public class BookingResultDto
{
    public long Id { get; set; }
    public int NumberOfTickets { get; set; }
    public decimal TotalPrice { get; set; }

    public UserResultDto User { get; set; }
    public FlightResultDto Flight { get; set; }
}
