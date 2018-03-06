using System;
using System.Collections.Generic;
using System.Text;

namespace _12_Farm
{
    class Farm
    {
        private List<Animal> animals = new List<Animal>();
        private int slots = 10;

        public Farm()
        {
            animals.Capacity = slots;
        }

        public void Breed()
        {
            if (animals.Count < slots)
            {
                animals.Add(new Animal());
            }
        }

        public void Slaughter()
        {
            int leastHungry = 0;

            for (int i = 0; i < animals.Count; i++)
            {
                if (animals[leastHungry].GetHunger() < animals[i].GetHunger())
                {
                    leastHungry = i;
                }
            }

            animals.RemoveAt(leastHungry);
        }

    }
}
