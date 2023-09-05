using System.ComponentModel;

namespace FlightBooking.Service.DTOs;

public class UserRegisterDto
{
    [DisplayName("FirstName")]
    public string FirstName { get; set; }

    [DisplayName("LastName")]
    public string LastName { get; set; }

    [DisplayName("Phone")]
    public string Phone { get; set; }
    
    [DisplayName("Email")]
    public string Email { get; set; }
    
    [DisplayName("Password")]
    public string Password { get; set; }
    [DisplayName("IsEmailConfirmed")]
    public string IsEmailConfirmed { get; set; }
}
