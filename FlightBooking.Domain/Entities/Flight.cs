using FlightBooking.Domain.Commons;
namespace FlightBooking.Domain.Entities;

public class Flight : Auditable
{
    public string FlightNumber { get; set; }
    public string DepartureAirport { get; set; }
    public string ArrivalAirport { get; set; }
    public DateTime DepartureDate { get; set; }
    public DateTime ArrivalDate { get; set; }
    public decimal Price { get; set; }
    public ICollection<Flight> Flights { get; set;}
}
