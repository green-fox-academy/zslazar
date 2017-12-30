using System;
using System.Collections.Generic;
using System.Text;

namespace FoxBank
{
    public class HungarianForint : Currency
    {
        // Create a HungarianForint class that inherits from the Currency.
        // Create a constructor that accepts the value.
        // The code should be "HUF"
        // and the central bank name should be "Hungarian National Bank

        public HungarianForint(int value) : base("HUF", "Hungarian National Bank", value)
        {
        }
               
    }
}
