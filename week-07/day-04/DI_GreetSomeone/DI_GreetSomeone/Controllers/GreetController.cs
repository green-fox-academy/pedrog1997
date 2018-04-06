using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DI_GreetSomeone.Services;
using Microsoft.AspNetCore.Mvc;

namespace DI_GreetSomeone.Controllers
{
    public class GreetController : Controller
    {
        private INameable _person;

        public GreetController(INameable person)
        {
            _person = person;
        }

        [HttpGet("/")]
        public IActionResult Index()
        {
            return View(_person);
        }

        [HttpPost("/")]
        public IActionResult Index(string name)
        {
            _person.Name = name;
            return RedirectToAction("greet");
        }

        [HttpGet("/greet")]
        public IActionResult Greet()
        {
            return View(_person);
        }
    }
}