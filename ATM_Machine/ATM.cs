using System;
using System.Collections.Generic;
using System.Text;

namespace ATM_Machine
{
    public class ATM
    {
        public ATM()
        {
            Balance = 100;
        }
        
        public double Balance { get; set; }

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
            Balance += 50;
        }
    }
}
