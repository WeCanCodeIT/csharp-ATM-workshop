using System;
using System.Collections.Generic;
using System.Text;

namespace ATM_Machine
{
    public class ATM
    {
        public double Balance { get; set; }

        public ATM()
        {
            Balance = 100.00;
        }

        public double GetBalance()
        {
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
