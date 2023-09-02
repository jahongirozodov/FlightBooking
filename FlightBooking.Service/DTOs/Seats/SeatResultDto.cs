using FlightBooking.Service.DTOs.Flights;

namespace FlightBooking.Service.DTOs.Seats;

public class SeatResultDto
{
    public long Id { get; set; }
    public string Seats { get; set; }
    public bool IsAvailable { get; set; }
    public FlightResultDto Flight { get; set; }
}
