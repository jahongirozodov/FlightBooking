using FlightBooking.Domain.Entities;

namespace FlightBooking.Service.DTOs.Seats;

public class SeatCreationDto
{
    public string Seats { get; set; }
    public bool IsAvailable { get; set; }
    public long FlightId { get; set; }
}
