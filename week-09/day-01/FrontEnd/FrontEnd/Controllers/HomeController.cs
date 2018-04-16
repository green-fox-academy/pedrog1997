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
        public IActionResult Doubling([FromQuery]int? input)
        {
            if (input == null)
            {
                var error = new ErrorDoubling()
                {
                    Error = "Please provide an input!"
                };
                return Json(error);
            }
            else
            {
                Models.Double doubling = new Models.Double
                {
                    Received = input,
                    Result = input * 2
                };
                return Json(doubling);
            }
        }

        [HttpGet("/Greeter")]
        public IActionResult Greeter([FromQuery]string name, [FromQuery]string title)
        {
            if (name == null || title == null)
            {
                var error = new ErrorDoubling
                {
                    Error = "Please provide a name!"
                };
                return Json(error);
            }
            else
            {
                var greeter = new Greeter
                {
                    Name = name,
                    Title = title
                };
                return Json(greeter);
            }
        }
    }
}