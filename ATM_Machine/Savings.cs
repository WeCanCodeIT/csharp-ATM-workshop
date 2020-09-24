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

        public Savings(string nickName, string accountNumber)
        {
            Balance = 200;
            AccountNumber = accountNumber;
            NickName = nickName;
        }

        public override double GetBalance()
        {
            // Console.WriteLine("Savings funds: " + Balance);
            return Balance;
        }
    }
}
