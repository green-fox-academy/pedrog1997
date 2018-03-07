using System;
using System.Collections.Generic;
using System.Text;

namespace _01_GreenFoxOrganization
{
    class Cohort
    {
        private string name;
        private List<Student> students = new List<Student>();
        private List<Mentor> mentors = new List<Mentor>();

        public Cohort(string name)
        {
            this.name = name;
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void AddMentor(Mentor mentor)
        {
            mentors.Add(mentor);
        }

        public void Info()
        {
            Console.WriteLine("The {0} cohort has {1} students and {2} mentors.", name, students.Count, mentors.Count);
        }
    }
}
