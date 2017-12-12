using System;
using System.Collections.Generic;
using System.Text;

namespace _01_GreenFox
{
    class Sponsor : Person
    {
        public string company { get; set; }
        public int hiredStudents { get; set; }
        
        public Sponsor(string name, int age, string gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }

        public Sponsor()
        {
            name = "Jane Doe";
            age = 30;
            gender = "female";
            company = "Google";
            hiredStudents = 0;
        }

        public void Introduce()
        {
            Console.WriteLine("Hi, I'm {0} a {1} year old {2} who represents {3} and hired {4} students so far.", name, age, gender, company, hiredStudents);
        }

        public void GetGoal()
        {
            Console.WriteLine("Hire brilliant junior software developers.");
        }

        public void Hire()
        {
            hiredStudents++;
        }
    }
}
