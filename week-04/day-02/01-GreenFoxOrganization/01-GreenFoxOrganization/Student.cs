using System;
using System.Collections.Generic;
using System.Text;

namespace _01_GreenFoxOrganization
{
    class Student : Person
    {
        private string previousOrganization = "The school of life";
        private int skippedDays = 0;

        public Student()
        {

        }

        public Student(string name, int age, string gender, string previousOrganization) : base(name, age, gender)
        {
            this.previousOrganization = previousOrganization;
        }

        public override void GetGoal()
        {
            Console.WriteLine("My goal is : be a junior software developer.");
        }

        public override void Introduce()
        {
            Console.WriteLine("Hi, I am {0}, a {1} years old {2} from {3} who skipped {4} days from the course already.", 
                name, age, gender, previousOrganization, skippedDays);
        }

        public void SkipDays(int numberOfDays)
        {
            skippedDays += numberOfDays;
        }
    }
}
