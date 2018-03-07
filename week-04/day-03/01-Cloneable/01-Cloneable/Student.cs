using System;
using System.Collections.Generic;
using System.Text;

namespace _01_Cloneable
{
    class Student : ICloneable
    {
        private string name = "Jane Doe";
        private int age = 30;
        private string gender = "female";
        private string previousOrganization = "The school of life";
        private int skippedDays = 0;

        public Student()
        {

        }

        public Student(string name, int age, string gender, string previousOrganization)
        {
            this.previousOrganization = previousOrganization;
        }

        public object Clone()
        {
            return new Student(name, age, gender, previousOrganization);
        }

        public void GetGoal()
        {
            Console.WriteLine("My goal is : be a junior software developer.");
        }

        public void Introduce()
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
