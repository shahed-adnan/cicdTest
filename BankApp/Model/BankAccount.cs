using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankApp.Model
{
    public class BankAccount
    {
        private double balance;
        public BankAccount() { }
        public BankAccount(double balance)
        {
            this.balance = balance;
        }
        public void Deposit(double amount)
        { 
           if(amount > 0)
           {
                balance += amount;
           }
        }
        public void Withdraw(double amount)
        {
            if(amount>0 && balance>amount)
            {
                balance -= amount;
            }
        }
        public double GetBalance()
        {
            return balance;
        }
        
    }
}
