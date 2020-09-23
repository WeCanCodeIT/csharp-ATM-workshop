using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ATM_Machine
{
    public class Account
    {
        public Account()
        {
            Balance = 100;
           
        }
        
        public double Balance { get; set; }
        public string AccountNumber { get; set; }
        public string NickName { get; set; }

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
            Balance += 50;
        }
    }
}
