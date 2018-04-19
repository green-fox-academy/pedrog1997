using ExampleExam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleExam.Repositories
{
    public class Repository : IRepository
    {
        private SpaceContext spaceDb;

        public Spaceship Spaceship
        {
            get
            {
                return spaceDb.Spaceship.First();
            }
        }

        public Repository(SpaceContext spaceDb)
        {
            this.spaceDb = spaceDb;
        }

        public Planet GetPlanet(int id)
        {
            return spaceDb.Planet.FirstOrDefault(p => p.Id == id);
        }

        public List<Planet> GetAllPlanets()
        {
            return spaceDb.Planet.ToList();
        }

        public void Update(Spaceship spaceship)
        {
            spaceDb.Update(spaceship);
            spaceDb.SaveChanges();
        }
        public void Update(Spaceship spaceship, Planet planet)
        {
            spaceDb.Update(spaceship);
            spaceDb.Update(planet);
            spaceDb.SaveChanges();
        }
    }
}
