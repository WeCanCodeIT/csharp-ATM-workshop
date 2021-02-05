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

        public Account SelectAccount()
        {
            int index = 1;

            Console.WriteLine("Please select an account from the list:");
            foreach (Account account in ListofAccounts)
            {
                Console.WriteLine($"{index}. {account.AccountNumber} {account.NickName}");
                index++;
            }

            int indexSelected = Convert.ToInt32(Console.ReadLine());

            return ListofAccounts[indexSelected - 1];


        }


    }
}
