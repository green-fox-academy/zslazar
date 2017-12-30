using System;
using System.Collections.Generic;
using System.Text;

namespace FoxBank
{
    // Create a UsaDollar class that inherits from the Currency.
    // Create a constructor that accepts the value.
    // The code should be "USD"
    // and the central bank name should be "Federal Reserve System"

    public class UsaDollar : Currency
    {
        public UsaDollar(int value) : base("USD", "Federal Reserve System", value)
        {
        }
        
    }
}
