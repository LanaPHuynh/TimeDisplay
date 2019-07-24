using Microsoft.AspNetCore.Mvc;
using System;

namespace TimeDisplay
{
    public class HomeController: Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            DateTime CurrentTime = DateTime.Now;
            ViewBag.time = CurrentTime.ToString("hh:mm tt");
            ViewBag.date = CurrentTime.ToString("MMM dd, yyyy");
            return View();
        }
        
    }
}