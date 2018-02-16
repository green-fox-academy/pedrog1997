using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers and prints the bigger one
            Console.WriteLine("Input a number");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Input a number");
            double num2 = double.Parse(Console.ReadLine());

            if(num1 >= num2)
            {
                Console.WriteLine("The biggest number is " + num1);
            }
            else
            {
                Console.WriteLine("The biggest number is " + num2);
            }
            Console.ReadLine();
        }
    }
}