using System;
using System.Collections.Generic;
using System.Text;

namespace ATM_Machine
{
    public class Account
    {
        public double Balance { get; set; }
        public string AccountNumber { get; set; }
        public string NickName { get; set; }

        public Account()
        {
            Balance = 100.00;
        }

        public virtual double GetBalance()
        {
            Console.WriteLine("Main account funds: " + Balance);
            return Balance;
        }

        public void Withdraw()
        {
            Balance -= 10;
        }

        public void Deposit()
        {
            Balance += 50; // Balance = Balance + 50
        }

        public void Deposit(double amount)
        {
            Balance += amount; // Balance = Balance + amount
        }
    }
}
