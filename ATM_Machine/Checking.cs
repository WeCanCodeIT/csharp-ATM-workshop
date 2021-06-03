using System;
using System.Collections.Generic;
using System.Text;

namespace ATM_Machine
{
    
    public class Checking : Account
    {
        public double MinimumRequiredBalance { get; set; }
        public int CheckNumber { get; set; }
        public Checking()
        {
            MinimumRequiredBalance = 200.00;
            CheckNumber = 1;
        }

        public void WriteCheck()
        {
            CheckNumber++;
        }

        public override double GetBalance()
        {
            Console.WriteLine("Checking account funds: " + Balance);
            return Balance;
        }
    }
}
