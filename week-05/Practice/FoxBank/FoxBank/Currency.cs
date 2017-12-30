using System;
using System.Collections.Generic;
using System.Text;

namespace FoxBank
{
    public class Currency
    {
        // Create a Currency class.
        // It should have a code, a central bank name and a value field.
        // Create a constructor for setting those values.

        private string code;
        private string bankName;
        public int Value { get; set; }

        public Currency(string code, string bankName, int value)
        {
            this.code = code;
            this.bankName = bankName;
            Value = value;
        }

        
    }
}
