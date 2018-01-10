﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba.Models
{
    public class BankAccount
    {
        public string Name { get; set; }
        public double Balance { get; set; }
        public string AnimalType { get; set; }
        public string Currency { get; set; } = "Yerba";

        public BankAccount(string name, double balance, string type)
        {
            Name = name;
            Balance = balance;
            AnimalType = type;
        }
    }
}