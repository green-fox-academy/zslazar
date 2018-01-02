using System;
using System.Collections.Generic;
using System.Text;

namespace Cloneable
{
    class Student : Person, ICloneable
    {
        public string previousOrganization { get; set; }
        public int skippedDays { get; set; }

        //ey a method ami uj
        public object Clone()
        {
            return this;
        }

        public Student(string name, int age, string gender, string previousOrganization) : base(name, age, gender)
        {
            this.previousOrganization = previousOrganization;
            skippedDays = 0;
        }

        public Student() : base()
        {
            previousOrganization = "The School of Life";
            skippedDays = 0;
        }

        public override void Introduce()
        {
            Console.WriteLine("Hi, I'm {0} a {1} year old {2} from {3} who skipped {4} " +
                "days from the course already. ", name, age, gender, previousOrganization, skippedDays);
        }

        public override void GetGoal()
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
