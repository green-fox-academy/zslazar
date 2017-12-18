using System;
using System.Collections.Generic;
using System.Text;

namespace Counter
{
    class Counter
    {
        public int Number { get; set; }

        public Counter()
        {
            Number = 0;
        }

        public Counter(int number)
        {
            Number = number;
        }

        public void Add()
        {
            Number++;
        }

        public void Add(int number)
        {
            Number += number;
        }

        public string Get()
        {
            return Number.ToString();
        }

        public int Reset()
        {
            return Number = 0;
        }
    }
}
