using System;
using System.Collections.Generic;
using System.Text;

namespace _01_GreenFoxOrganization
{
    class Person
    {
        protected string name = "Jane Doe";
        protected int age = 30;
        protected string gender = "female";

        public Person()
        {

        }

        public Person(string name, int age, string gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }

        public virtual void Introduce()
        {
            Console.WriteLine("Hi, I am {0}, a {1} years old {2}", name, age, gender);
        }

        public virtual void GetGoal()
        {
            Console.WriteLine("My goal is: Live for the moment!");
        }
    }
}
