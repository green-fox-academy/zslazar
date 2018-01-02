using System;
using System.Collections.Generic;
using System.Text;

namespace Comparable
{
    public class Domino : IComparable
    {
        private readonly int[] Values;

        public Domino(int valueA, int valueB)
        {
            this.Values = new int[] { valueA, valueB };
        }

        public int[] GetValues()
        {
            return Values;
        }

        public int CompareTo(Domino domino)
        {
            int number = 0;
            if (domino.Values[0] < Values[0])
            {

            }


        }
    }
}
