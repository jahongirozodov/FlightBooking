using FlightBooking.Service.DTOs.Flights;

namespace FlightBooking.Service.DTOs.Tickets;

public class TicketResultDto
{
    public long Id { get; set; }
    public decimal Price { get; set; }
    public FlightResultDto Flight { get; set; }
    public UserResultDto User { get; set; }
}
