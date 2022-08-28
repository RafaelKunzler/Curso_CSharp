using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula155.Entities.Exceptions;


namespace Aula155.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if  (amount > WithdrawLimit)
            {
                throw new DomainExceptions("The amount exceeds withdraw limit.");
            }
            else if (Balance <= amount)
            {                
                throw new DomainExceptions("Not enough balance.");
            }

            Balance -= amount;
        }

    }
}
