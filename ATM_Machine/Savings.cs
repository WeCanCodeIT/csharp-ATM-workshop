using System;
using System.Collections.Generic;
using System.Text;

namespace ATM_Machine
{
    public class Savings : Account
    {
        public Savings()
        {
            Balance = 200.00;
        }

        public Savings(string name, string account)
        {
            NickName = name;
            AccountNumber = account;
        }

        public override double GetBalance()
        {
            Console.WriteLine("Savings account funds: " + Balance);
            return Balance;
        }
    }
}
