using System;
using System.Collections.Generic;
using System.Text;

namespace FoxBank
{
    public class BankAccount
    {
        // Create a BankAccount class.
        // It should have a name, a pin code and a Currency field.
        // Create a constructor for setting those values.
        // Create a deposit method which check if the given parameter is positive
        // then adds the parameter to the Currency's value field.

        // Create a withdraw method with two parameters: a pin code and an amount.
        // It should check if the given pin is correct (equals with the original pin)
        // and the Currency's value is more than the amount parameter.
        // If so, subtract the amount from the Currency's value and return with the amount.
        // Otherwise don't modify the Currency's value and return with 0.


        private string name;
        private string pin;
        public Currency Currency { get; set; } 

        public BankAccount(string name, string pin, Currency currency)
        {
            this.name = name;
            this.pin = pin;
            Currency = currency;
        }

        public void Deposit(int money)
        {
            if (money > 0)
                Currency.Value += money;
            //Currency.Value a betett penz 
            //if (money > 0)
            //{
            //    Currency = money + Currency;
            //}
        }

        public int Withdraw(string userPin, int amount)
        {
            int addOutMoney = 0;
            if (userPin == pin && Currency.Value > amount)
            {
                addOutMoney = amount;
                Currency.Value = Currency.Value - amount;
                //Currency.Value -= amount;
            }
            return addOutMoney;

        }
    }
}
