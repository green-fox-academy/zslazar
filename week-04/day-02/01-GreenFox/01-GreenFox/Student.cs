using System;
using System.Collections.Generic;
using System.Text;

namespace _01_GreenFox
{
    class Student : Person
    {
        public string previousOrganization { get; set; }
        public int skippedDays { get; set; }

        public Student(string name, int age, string gender, string previousOrganization)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.previousOrganization = previousOrganization;
            this.skippedDays = 0;
        }

        public Student()
        {
            name = "Jane Doe";
            age = 30;
            gender = "female";
            previousOrganization = "The School of Life";
            skippedDays = 0;
        }

        public void Introduce()
        {
            Console.WriteLine("Hi, I'm {0} a {1} year old {2} from {3} who skipped {4} " +
                "days from the course already. ", name, age, gender, previousOrganization, skippedDays);
        }

        public void GetGoal()
        {
            Console.WriteLine("My goal is: Live for the moment {0}!", name);
        }

        public int SkipDays(int numberOfDays)
        {
            numberOfDays = numberOfDays + skippedDays;
            return skippedDays;
        }
    }
}
