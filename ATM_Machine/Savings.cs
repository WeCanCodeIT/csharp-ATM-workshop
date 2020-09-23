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

        public override double GetBalance()
        {
            Console.WriteLine("Savings funds: " + Balance);
            return Balance;
        }
    }
}
