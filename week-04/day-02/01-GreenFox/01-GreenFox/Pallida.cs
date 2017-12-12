using System;
using System.Collections.Generic;
using System.Text;

namespace _01_GreenFox
{
    class Pallida : Person
    {
        public string className { get; set; }
        public List<Student> students { get; set; }
        List<Mentor> mentors { get; set; }

        public Pallida(string className)
        {
            //+it sets students and mentors as empty lists
            this.className = className;
            students = new List<Student>();
            mentors = new List<Mentor>();
        }

        public void AddStudent(Student s)
        {
            // adds the given Student to students list
            students.Add(s);
        }

        public void AddMentor(Mentor m)
        {
            //adds the given Mentor to mentors list
            mentors.Add(m);
        }

        public void Info()
        {
            Console.WriteLine("Pallida {0} class has {1} students and {2} mentors.", className, students.Count, mentors.Count);
        }
    }
}
