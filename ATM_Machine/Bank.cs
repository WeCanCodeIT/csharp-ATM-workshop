using System;
using System.Collections.Generic;
using System.Text;

namespace ATM_Machine
{
    public class Bank
    {
        public List<Account> ListOfAccounts = new List<Account>();
        public Bank()
        {

        }

        public void AddAccount(Account account)
        {
            ListOfAccounts.Add(account);
        }

        public void RemoveAccount(int i)
        {
            ListOfAccounts.RemoveAt(i);
        }
    }
}
