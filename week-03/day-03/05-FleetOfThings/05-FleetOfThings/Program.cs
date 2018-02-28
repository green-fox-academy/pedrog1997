using System;

namespace _05_FleetOfThings
{
    class Program
    {
        public class FleetOfThings
        {
            public static void Main(string[] args)
            {
                var fleet = new Fleet();
                // Create a fleet of things to have this output:
                // 1. [ ] Get milk
                // 2. [ ] Remove the obstacles
                // 3. [x] Stand up
                // 4. [x] Eat lunch
                // Hint: You have to create a Print method also

                Thing getMilk = new Thing("Get milk");
                Thing removeObstacles = new Thing("Remove the obstacles");
                Thing standUp = new Thing("Stand up");
                standUp.Complete();
                Thing eatLunch = new Thing("Eat lunch");
                eatLunch.Complete();

                fleet.Add(getMilk);
                fleet.Add(removeObstacles);
                fleet.Add(standUp);
                fleet.Add(eatLunch);

                fleet.PrintFleet();

                Console.Read();
            }
        }
    }
}
