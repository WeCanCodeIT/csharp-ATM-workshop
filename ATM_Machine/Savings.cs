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
            Balance = 200.00;
            NickName = nickName;
            AccountNumber = accountNumber;
        }




    }
}
