using System;
using System.Collections.Generic;
using System.Text;

namespace _01_GreenFoxOrganization
{
    class Mentor : Person
    {
        private string level = "intermidiate";

        public Mentor()
        {

        }

        public Mentor(string name, int age, string gender, string level) : base(name, age, gender)
        {
            this.level = level;
        }

        public override void GetGoal()
        {
            Console.WriteLine("My goal is : educate brilliant junior software developers");
        }

        public override void Introduce()
        {
            Console.WriteLine("Hi, I am {0}, a {1} years old {2} {3} mentor.", name, age, gender, level);
        }
    }
}
