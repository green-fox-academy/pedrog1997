using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DI_Counter.Models;
using DI_Counter.Services;

namespace DI_Counter.Controllers
{
    public class CounterController : Controller
    {
        private ICounter _counter = new Counter();

        public CounterController(ICounter counter)
        {
            _counter = counter;
        }

        [HttpGet("/index")]
        public IActionResult Index()
        {
            return View(_counter);
        }

        [HttpPost("/index")]
        public IActionResult Counter()
        {
            _counter.IncreaseNumber();
            return RedirectToAction("index");
        }
    }
}