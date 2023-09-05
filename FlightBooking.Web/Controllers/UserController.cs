using AspNetCore;
using FlightBooking.Service.DTOs;
using FlightBooking.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace FlightBooking.Web.Controllers
{
    public class UserController : Controller
    {
        private IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> Register(UserRegisterDto dto)
        {
            var result = await userService.RegisterAsync(dto);
            return RedirectToRoute(new { controller = "Main", action = "Index"});
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserLoginDto dto)
        {
            var result = await userService.LoginAsync(dto);
            if(result is true)
                return RedirectToRoute(new { controller = "Main", action = "Index" });
            return View();
        }
    }
}
