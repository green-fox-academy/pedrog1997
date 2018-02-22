using System;

namespace Calculator
{
    public class Calculator
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please type in the expression with this format: {operation} {operand} {operand}. \n " +
                "The operations supporte are: +, -, *, /, %. \n" +
                "An example could look like this: \"+ 3 3\" \n" +
                "This would return 6");
            string expression = Console.ReadLine();
            string[] separatedExpression = expression.Split(" ");
            double operator1 = double.Parse(separatedExpression[1]);
            double operator2 = double.Parse(separatedExpression[2]);

            Console.WriteLine(Calculate(separatedExpression[0], operator1, operator2));
            Console.Read();
            
        }

        public static double Calculate(string operand, double operator1, double operator2)
        {
            double result = 0;
            switch (operand)
            {
                case ("+"):
                    result = operator1 + operator2;
                    break;
                case ("-"):
                    result = operator1 - operator2;
                    break;
                case ("*"):
                    result = operator1 * operator2;
                    break;
                case ("/"):
                    result = operator1 / operator2;
                    break;
                case ("%"):
                    result = operator1 % operator2;
                    break;
                default:
                    Console.WriteLine("This calculator doesn't support that operand.");
                    break;
            }
            return result;
        }
    }
}