using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FrontEnd.Models;

namespace FrontEnd.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        [Route("/")]    
        public IActionResult Index()
        {
            return File("index.html", "text/html");
        }

        [HttpGet("/doubling")]
        public IActionResult Doubling([FromQuery]int input)
        {
            Models.Double doubling = new Models.Double
            {
                Received = input,
                Result = input * 2
            };
            return Json(doubling);
        }
    }
}