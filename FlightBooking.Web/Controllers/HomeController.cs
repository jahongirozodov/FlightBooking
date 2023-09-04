using FlightBooking.Service.DTOs;
using FlightBooking.Service.Interfaces;
using FlightBooking.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FlightBooking.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserService userService;
        public HomeController(ILogger<HomeController> logger, IUserService userService)
        {
            _logger = logger;
            this.userService = userService;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();  
        }

        [HttpPost]
        public IActionResult Register(UserRegisterDto dto)
        {
            var user = userService.RegisterAsync(dto);
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}