using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // An average Green Fox attendee codes 6 hours daily
            // The semester is 17 weeks long
            //
            // Print how many hours is spent with coding in a semester by an attendee,
            // if the attendee only codes on workdays.
            Console.WriteLine("An average Green Fox attendee codes " + 6 * 5 * 17 + " in a semester.");
            // Print the percentage of the coding hours in the semester if the average
            // work hours weekly is 52
            Console.WriteLine("An average Green Fox atendee codes " + 52 * 17 + " in a semester.");
            Console.Read();
        }
    }
}
