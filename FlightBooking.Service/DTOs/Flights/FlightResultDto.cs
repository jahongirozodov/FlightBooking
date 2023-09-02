using FlightBooking.Domain.Entities;

namespace FlightBooking.Service.DTOs.Flights;

public class FlightResultDto
{
    public long Id { get; set; }
    public string FlightNumber { get; set; }
    public string DepartureAirport { get; set; }
    public string ArrivalAirport { get; set; }
    public DateTime DepartureDate { get; set; }
    public DateTime ArrivalDate { get; set; }
    public decimal Price { get; set; }
    public ICollection<Flight> Flights { get; set; }
}
