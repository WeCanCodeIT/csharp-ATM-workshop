using System;
using System.Collections.Generic;
using System.Text;

namespace ATM_Machine
{
    public class Bank
    {
        public List<Account> ListOfAccounts = new List<Account>();

        public void AddAccount(Account account)
        {
            ListOfAccounts.Add(account);
        }

        public Account SelectAccount()
        {
            int index = 1;

            Console.WriteLine("Please select an account from the list:");
            foreach(Account account in ListOfAccounts)
            {
                Console.WriteLine($"{index}. {account.AccountNumber} {account.NickName}");
                index++;
            }

            int indexSelected = Convert.ToInt32(Console.ReadLine());
            return ListOfAccounts[indexSelected - 1];
        }
    }
}
