using System;
using System.Collections.Generic;
using System.Text;

namespace _02_TheGardenApplication
{
    class Garden
    {
        private List<Plant> plants = new List<Plant>();

        public Garden(List<Plant> plants)
        {
            this.plants = plants;
            GardenStatus();
        }

        private void GardenStatus()
        {
            for (int i = 0; i < plants.Count; i++)
            {
                if (plants[i].NeedsWater)
                    Console.WriteLine("The {0} {1} needs water", plants[i].Color, plants[i].name);
                else
                    Console.WriteLine("The {0} {1} doesn't need water", plants[i].Color, plants[i].name);
            }
            Console.WriteLine();
        }

        public void WaterPlants(double amountOfWater)
        {
            int plantsThatNeedWater = 0;

            for (int i = 0; i < plants.Count; i++)
            {
                if (plants[i].NeedsWater)
                {
                    plantsThatNeedWater++;
                }
            }

            double individualWater = amountOfWater / plantsThatNeedWater;

            for (int i = 0; i < plants.Count; i++)
            {
                if (plants[i].NeedsWater)
                {
                    plants[i].AbsorbWater(individualWater);
                }
            }

            Console.WriteLine("Watering with {0}", amountOfWater);
            GardenStatus();
        }
    }
}
