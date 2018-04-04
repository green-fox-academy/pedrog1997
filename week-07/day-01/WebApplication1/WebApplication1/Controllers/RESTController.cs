using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api")]
    public class RESTController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("Greeting")]
        public IActionResult Greeting()
        {
            var greeting = new Greeting()
            {
                Id = 1,
                Content = "Hello World!"
            };

            return new JsonResult(greeting);
        }
    }
}