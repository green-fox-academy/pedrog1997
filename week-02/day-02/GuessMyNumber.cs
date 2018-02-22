using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the range of numbers with this format: min-max \n" +
                "Example: \"0-100\"");
            string strRange = Console.ReadLine();
            string[] strArrayRange = strRange.Split("-");
            int min = Convert.ToInt32(strArrayRange[0]);
            int max = Convert.ToInt32(strArrayRange[1]);

            int numberToGuess = GenerateRandomNumber(min, max);

            int lives = 10;

            Console.WriteLine("Guess the number I'm thinking from" + strArrayRange[0] + "to" + strArrayRange[1] + "\n" +
                "You have 10 lives");

            while (lives > 0)
            {
            int guessInput = int.Parse(Console.ReadLine());

                if (guessInput == numberToGuess)
                {
                    Console.WriteLine("Congratulations!! You guessed the right number!!");
                    break;
                }
                else if (guessInput > numberToGuess)
                {
                    lives--;
                    Console.WriteLine("Too high. You have " + lives + " left.");
                }
                else
                {
                    lives--;
                    Console.WriteLine("Too low. You have " + lives + " left.");
                }
            }

            if (lives == 0)
            {
                Console.WriteLine("Sorry you are out of lives. Game over. \n" +
                    "The number was " + numberToGuess);
            }

            Console.Read();
        }

        public static int GenerateRandomNumber(int min, int max)
        {
            Random randomNuber = new Random();
            int numberToGuess = randomNuber.Next(min, max);
            return numberToGuess;
        }
    }
}