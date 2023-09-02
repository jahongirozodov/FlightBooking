namespace FlightBooking.Service.DTOs.Tickets;

public class TicketUpdateDto
{
    public long Id { get; set; }
    public decimal Price { get; set; }
    public long FlightId { get; set; }
    public long UserId { get; set; }
}
