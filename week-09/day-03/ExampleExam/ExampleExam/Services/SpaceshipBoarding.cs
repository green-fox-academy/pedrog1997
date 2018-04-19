using ExampleExam.Models;
using ExampleExam.Repositories;
using ExampleExam.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleExam.Services
{
    public class SpaceshipBoarding : ISpaceshipBoarding
    {
        private IRepository repo;

        public SpaceshipBoarding(IRepository repo)
        {
            this.repo = repo;
        }

        public PlanetsShip Model
        {
            get
            {
                return new PlanetsShip
                {
                    Planets = repo.GetAllPlanets(),
                    Spaceship = repo.Spaceship
                };
            }
        }

        public void MoveHere(int id)
        {
            string targetPlanet = repo.GetPlanet(id).Name;
            string actualPlanet = repo.Spaceship.Planet;
            if (targetPlanet != actualPlanet)
            {
                Spaceship spaceShip = repo.Spaceship;
                spaceShip.Planet = targetPlanet;
                repo.Update(spaceShip);
            }
        }

        public void ToShip(int id)
        {
            Spaceship spaceship = repo.Spaceship;
            Planet planet = repo.GetPlanet(id);
            long peopleOnPlanet = planet.Population;
            int peopleOnSpaceShip = spaceship.Utilization;
            if (peopleOnPlanet + peopleOnSpaceShip > 50)
            {
                spaceship.Utilization = 50;
                planet.Population -= (50 - peopleOnSpaceShip);
            }
            else
            {
                spaceship.Utilization += (int)peopleOnPlanet;
                peopleOnPlanet = 0;
            }
            repo.Update(spaceship, planet);
        }

        public void ToPlanet(int id)
        {
            Spaceship spaceship = repo.Spaceship;
            Planet planet = repo.GetPlanet(id);
            int peopleOnSpaceShip = spaceship.Utilization;
            spaceship.Utilization = 0;
            planet.Population += peopleOnSpaceShip;
            repo.Update(spaceship, planet);
        }
    }
}
