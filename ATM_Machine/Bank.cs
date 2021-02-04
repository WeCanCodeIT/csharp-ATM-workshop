using System;
using System.Collections.Generic;
using System.Text;

namespace ATM_Machine
{
    public class Bank
    {
        public List<Account> ListofAccounts = new List<Account>();


        public void AddAccount(Account account)
        {
            ListofAccounts.Add(account);
        }


    }
}
