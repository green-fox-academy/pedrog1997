using System;

namespace _06_Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            var animal = new Animal();
            animal.Play();
            animal.Eat();
            animal.Drink();

            Console.Read();
        }
    }
}
