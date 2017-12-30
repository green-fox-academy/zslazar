using System;

namespace FoxBank
{
    public class Program
    {
        static void Main(string[] args)
        {                            
                     
            // For example:

            Currency janeCash = new UsaDollar(1500);

            var janeAcc = new BankAccount("Jane", "1234", janeCash);
            janeAcc.Deposit(500);

            int janeWithdraw = janeAcc.Withdraw("1111", 500);
            Console.WriteLine("janeWithdraw = " + janeWithdraw);
            // janeWithdraw = 0

            janeWithdraw = janeAcc.Withdraw("1234", 500);
            Console.WriteLine("janeWithdraw = " + janeWithdraw);
            // janeWithdraw = 500

            janeWithdraw = janeAcc.Withdraw("1234", 2000);
            Console.WriteLine("janeWithdraw = " + janeWithdraw);
            // janeWithdraw = 0

            Currency johnnyCash = new HungarianForint(500);

            var myBank = new Bank();
            myBank.CreateAccount(janeAcc);
            myBank.CreateAccount(new BankAccount("Johnny", "1993", johnnyCash));

            int allMoney = myBank.GetAllMoney();
            Console.WriteLine("allMoney = " + allMoney);
            // allMoney = 2000

            Console.ReadLine();
        }
    }
}
