using System;
using System.Collections.Generic;
using System.Text;

namespace FoxBank
{
    // Create a Bank class which can store BankAccounts.
    // It should have a createAccount method with a BankAccount as an input parameter.
    // It should have a getAllMoney method, which returns the sum of
    // the accounts' money (sum of Currency values regardless of the Currency type).

    public class Bank
    {
        List<BankAccount> bankAccounts = new List<BankAccount>();

        public void CreateAccount(BankAccount account)
        {
            bankAccounts.Add(account);
        }

        public int GetAllMoney()
        {
            int allMoney = 0;
            foreach (var anyAccount in bankAccounts)
            {
                allMoney += anyAccount.Currency.Value;
            }
            return allMoney;
        }
    }
}
