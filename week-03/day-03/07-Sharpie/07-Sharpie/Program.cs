using System;

namespace _07_Sharpie
{
    class Program
    {
        static void Main(string[] args)
        {
            var sharpie = new Sharpie("orange", 50f);
            sharpie.Use();
            sharpie.Use();

            Console.Read();

        }
    }
}
