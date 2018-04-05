using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankOfSimba.Models;
using Microsoft.AspNetCore.Mvc;

namespace BankOfSimba.Controllers
{
    [Route("")]
    public class SimbaController : Controller
    {
        [Route("simba")]
        public IActionResult Simba()
        {
            var bankAccountSimba = new BankAccount("Simba", 2000, "Animal.Lion");

            return View(bankAccountSimba);
        }

        [Route("bankAccounts")]
        public IActionResult BankAccounts()
        {
            var bankAccount = new List<BankAccount>
            {
                new BankAccount("Simba", 2000, "Animal.Lion"),
                new BankAccount("Timon", 150, "Animal.Zuricata"),
                new BankAccount("Pumba", 150, "Animal.RedPig"),
                new BankAccount("Nala", 2000, "Animal.Lioness"),
                new BankAccount("Scar", 0, "Animal.EvilLion")
            };

            return View(bankAccount);
        }
    }
}