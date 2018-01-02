using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    class Car : IMoveable
    {
        public int distanceTaken;

        public Car()
        {
            distanceTaken = 0;
        }

        public void Move(int meter)
        {
            distanceTaken += meter;
        }
    }
}
