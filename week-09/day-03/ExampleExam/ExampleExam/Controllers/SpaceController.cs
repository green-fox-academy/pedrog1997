using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExampleExam.Models;
using ExampleExam.Repositories;
using ExampleExam.Services;
using Microsoft.AspNetCore.Mvc;

namespace ExampleExam.Controllers
{
    [Route("")]
    public class SpaceController : Controller
    {
        private ISpaceshipBoarding ship;

        public SpaceController(ISpaceshipBoarding ship)
        {
            this.ship = ship;
        }

        [HttpGet("/")]
        public IActionResult Index()
        {
            return View(ship.Model);
        }

        [HttpGet("/movehere/{id}")]
        public IActionResult Move(int id)
        {
            ship.MoveHere(id);
            return RedirectToAction("Index", ship.Model);
        }

        [HttpGet("/toship/{id}")]
        public IActionResult ToShip(int id)
        {
            ship.ToShip(id);
            return RedirectToAction("Index", ship.Model);
        }

        [HttpGet("/toplanet/{id}")]
        public IActionResult ToPlanet(int id)
        {
            ship.ToPlanet(id);
            return RedirectToAction("Index", ship.Model);
        }
    }
}