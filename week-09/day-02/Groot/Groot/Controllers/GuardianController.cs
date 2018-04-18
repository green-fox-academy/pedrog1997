using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Groot.Models;
using Microsoft.AspNetCore.Mvc;

namespace Groot.Controllers
{
    public class GuardianController : Controller
    {
        [HttpGet("/Groot")]
        public IActionResult Groot([FromQuery]string message)
        {
            if (message != null)
            {
                var grootMessage = new GrootResponse()
                {
                    Received = message,
                    Translated = "I am Groot!"
                }; 
            return Json(grootMessage);
            }
            else
            {
                var error = new Error()
                {
                    Error = "I am Groot!"
                };
                return Json(error);
            }
        }
    }
}
