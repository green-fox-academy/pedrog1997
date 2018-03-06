using System;
using System.Collections.Generic;
using System.Text;

namespace _12_Farm
{
    class Animal
    {
        private int hunger = 50;
        private int thirst = 50;

        public Animal()
        {
            Console.WriteLine("Your animal has a hunger value of " + hunger + " and a thirst value of " + thirst);
        }

        public void SetHunger(int hunger)
        {
            this.hunger = hunger;
        }

        public int GetHunger()
        {
            return hunger;
        }

        public void SetThirst(int thirst)
        {
            this.thirst = thirst;
        }

        public void Eat()
        {
            hunger--;
            Console.WriteLine("After eating, your animal has a hunger value of " + hunger);
        }

        public void Drink()
        {
            thirst--;
            Console.WriteLine("After drinking, your animal has a thirst value of " + thirst);
        }

        public void Play()
        {
            hunger++;
            thirst++;
            Console.WriteLine("After playing, your animal has a hunger value of " + hunger + " and a thirst value of " + thirst);
        }
    }
}
