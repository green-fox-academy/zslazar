using System;
using System.Collections.Generic;
using System.Text;
using Sum02;

namespace Sum02
{
    public class Sum
    {
        private int sum;

        public Sum(int sum)
        {
            this.sum = sum;
        }

        public int PrintSum()
        {
            Console.WriteLine(sum);
            return sum;
        }

    }
}
