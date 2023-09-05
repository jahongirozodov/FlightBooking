using FlightBooking.Service.DTOs;
using FlightBooking.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FlightBooking.Web.Controllers
{
    public class FlightController : Controller
    {
        public IUserService userService;
        public FlightController(IUserService userService)
        {
            this.userService = userService;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
