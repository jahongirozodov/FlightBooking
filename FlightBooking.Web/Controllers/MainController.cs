﻿using Microsoft.AspNetCore.Mvc;

namespace FlightBooking.Web.Controllers
{
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
