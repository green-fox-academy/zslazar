using System;
using System.Collections.Generic;
using System.Text;

namespace _01_GreenFox
{
    class Mentor : Person
    {
        public string level { get; set; }

        public Mentor(string name, int age, string gender, string level) : base(name, age, gender)
        {
            this.level = level;
        }

        public Mentor()
        {
            name = "Jane Doe";
            age = 30;
            gender = "female";
            level = "intermediate";
        }

        public override void Introduce()
        {
            Console.WriteLine("Hi, I'm {0} a {1} year old {2} {3} mentor", name, age, gender, level);
        }

        public override void GetGoal()
        {
            Console.WriteLine("Educate brilliant junior software developers.");
        }
    }
}
