using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace DesignByContractSharp
{
    class Account
    {
        double balance = 100;
        public void Deposit(double amount)
        {
            Contract.Requires(amount > 0);
            Contract.Ensures(balance >= Contract.Result<double>());
            if (amount < 0) throw new Exception("amount cannot be negative numbers");
            balance += amount;
            Console.Write("balance is now:" + balance);
        }
        public double Withdraw(double amount)
        {
            Contract.Requires(amount > 0);
            Contract.Requires(amount <= balance);
            Contract.EnsuresOnThrow<Exception>(amount > balance);
            if (amount > balance) throw new Exception("the amount exceeds the balance");
            Console.Write(amount - balance);
            balance =- amount;
            return balance;
        }
    }
}
