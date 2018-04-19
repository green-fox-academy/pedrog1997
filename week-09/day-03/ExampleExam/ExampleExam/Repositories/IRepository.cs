using ExampleExam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleExam.Repositories
{
    public interface IRepository
    {
        Spaceship Spaceship { get;}

        Planet GetPlanet(int id);
        List<Planet> GetAllPlanets();
        void Update(Spaceship spaceship);
        void Update(Spaceship spaceship, Planet planet);
    }
}
