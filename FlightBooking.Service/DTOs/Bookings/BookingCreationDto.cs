using FlightBooking.Domain.Entities;

namespace FlightBooking.Service.DTOs.Bookings;

public class BookingCreationDto
{
    public int NumberOfTickets { get; set; }
    public decimal TotalPrice { get; set; }

    public long UserId { get; set; }
    public long FlightId { get; set; }
}
