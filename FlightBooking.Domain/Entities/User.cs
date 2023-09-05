using FlightBooking.Domain.Commons;

namespace FlightBooking.Domain.Entities;
public class User : Auditable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? Phone { get; set; }
    public string Email {get; set; }
    public string PasswordHash { get; set; }
    public string Salt {get; set; }
    public bool IsEmailConfirmed { get; set; }
}
