using System;
using System.Collections.Generic;
using System.Text;

namespace Comparable
{
    public class Domino : IComparable<Domino>
    {
        private readonly int[] Values;

        public Domino(int valueA, int valueB)
        {
            this.Values = new int[] { valueA, valueB };
        }

        public int CompareTo(Domino nextDomino)
        {
            if (Values[0] != nextDomino.Values[0])
            {
                if (Values[0] > nextDomino.Values[0])
                {
                    return 1;
                }
                else if (Values[0] < nextDomino.Values[0])
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
            else if ((Values[0] == nextDomino.Values[0]))
            {
                if (Values[1] > nextDomino.Values[1])
                {
                    return 1;
                }
                else if (Values[1] < nextDomino.Values[1])
                {
                    return -1;
                }
                else
                {
                    return 0;
                }

            }
            else
            {
                return 0;
            }
        }

        public int[] GetValues()
        {
            return Values;
        }

        
    }
}
