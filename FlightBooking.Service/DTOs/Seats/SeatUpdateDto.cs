namespace FlightBooking.Service.DTOs.Seats;

public class SeatUpdateDto
{
    public long Id { get; set; }
    public string Seats { get; set; }
    public bool IsAvailable { get; set; }
    public long FlightId { get; set; }
}
