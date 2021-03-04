using System;
using System.Collections.Generic;
using System.Text;

namespace NewBasics1
{
    class AccountTest
    {
        static void Main(string[] args)
        {
            //create an instance of Account
            Accounts objAccount = new Accounts(1000);
            Console.WriteLine("After creating account :");
            objAccount.ShowBalance();

            objAccount.deposit(5000);
            Console.WriteLine("After depositing amount :");
            objAccount.ShowBalance();

            objAccount.withdraw(1700);
            Console.WriteLine("After withdrawing :");
            objAccount.ShowBalance();
        }
    }
}
