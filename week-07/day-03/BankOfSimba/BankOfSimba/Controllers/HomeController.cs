using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankOfSimba.Models;
using Microsoft.AspNetCore.Mvc;

namespace BankOfSimba.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("simba")]
        public IActionResult Simba()
        {
            var bankAccountSimba = new BankAccount("Simba", "2000", "Animal.Lion");

            return View();
        }
    }
}