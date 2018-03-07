using System;

namespace _01_Cloneable
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student("John", 20, "male", "BME");

            var student02 = student.Clone() as Student;
            student02.SkipDays(5);

            student.Introduce();
            student02.Introduce();

            Console.Read();
        }
    }
}
