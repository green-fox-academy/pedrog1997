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
        static List<BankAccount> bankAccounts = new List<BankAccount>
        {
            new BankAccount("Simba", 2000, "Animal.Lion"),
            new BankAccount("Timon", 150, "Animal.Zuricata"),
            new BankAccount("Pumba", 150, "Animal.RedPig"),
            new BankAccount("Nala", 2000, "Animal.Lioness"),
            new BankAccount("Scar", 0, "Animal.EvilLion"),
            new BankAccount("Pedro", 1000, "Animal.Human")
        };

        [Route("simba")]
        public IActionResult Simba()
        {
            return View(bankAccounts[0]);
        }

        [Route("bankAccounts")]
        public IActionResult BankAccounts()
        {
            
            bankAccounts[0].MakeKing();
            bankAccounts[4].MakeBad();

            return View(bankAccounts);
        }

        [Route("raiseCurrency")]
        [HttpPost]
        public IActionResult RaiseCurrency(int index)
        {
            bankAccounts[index].RaiseBalance();
            return View("bankAccounts", bankAccounts);
        }
    }
}