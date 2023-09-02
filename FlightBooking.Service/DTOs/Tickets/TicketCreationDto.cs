using FlightBooking.Domain.Entities;

namespace FlightBooking.Service.DTOs.Tickets;

public class TicketCreationDto
{
    public decimal Price { get; set; }
    public long FlightId { get; set; }
    public long UserId { get; set; }
}
