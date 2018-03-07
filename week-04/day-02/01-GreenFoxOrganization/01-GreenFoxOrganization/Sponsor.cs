using System;
using System.Collections.Generic;
using System.Text;

namespace _01_GreenFoxOrganization
{
    class Sponsor : Person
    {
        private string company = "Google";
        private int hiredStudents = 0;

        public Sponsor()
        {

        }

        public Sponsor(string name, int age, string gender, string company) : base(name, age, gender)
        {
            this.company = company;
        }

        public override void Introduce()
        {
            Console.WriteLine("Hi, I am {0}, a {1} years old {2} who represents {3} and hired {4} students do far.",
                name, age, gender, company, hiredStudents);
        }

        public void Hire()
        {
            hiredStudents++;
        }

        public override void GetGoal()
        {
            Console.WriteLine("My goal is: hire brilliant junior software developers.");
        }
    }
}
