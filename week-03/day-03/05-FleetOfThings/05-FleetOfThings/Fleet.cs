using System;
using System.Collections.Generic;
using System.Text;

namespace _05_FleetOfThings
{
    class Fleet
    {
        private List<Thing> Things;

        public Fleet()
        {
            Things = new List<Thing>();
        }

        public void Add(Thing thing)
        {
            Things.Add(thing);
        }

        public void PrintFleet()
        {
            string[] fleetStringArray = new string[Things.Count];
            string done = "[ ] ";

            for (int i = 0; i < fleetStringArray.Length; i++)
            {
                if (Things[i].IsCompleted())
                {
                    done = "[x] ";
                }
                fleetStringArray[i] = $"{i+1}. " + done + Things[i].GetName();
                done = "[ ] ";
            }

            string fleetString = string.Join("\n", fleetStringArray);

            Console.WriteLine(fleetString);
        }
    }
}
