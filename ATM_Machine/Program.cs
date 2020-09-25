using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;

namespace ATM_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank myBank = new Bank();
            Account myAccount = new Account();
            
            Console.WriteLine("Welcome to ATM Machine");

            bool keepBanking = true;
            while (keepBanking)
            {
                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("1. Add checking account");
                Console.WriteLine("2. Add savings account");
                Console.WriteLine("3. Check balance of all accounts");
                Console.WriteLine("4. Withdraw $10");
                Console.WriteLine("5. Deposit $50");
                Console.WriteLine("6. Exit");

                string atmChoice = Console.ReadLine();

                switch (atmChoice)
                {
                    case "1":
                        Console.WriteLine("What is the nickname for your checking account?");
                        string nickName = Console.ReadLine();
                        Console.WriteLine("What is the account number for your checking account?");
                        string accountNumber = Console.ReadLine();
                        myAccount = new Checking(nickName, accountNumber);
                        myBank.AddAccount(myAccount);
                        break;
                    case "2":
                        Console.WriteLine("What is the nickname for your savings account?");
                        nickName = Console.ReadLine();
                        Console.WriteLine("What is the account number for your savings account?");
                        accountNumber = Console.ReadLine();
                        myAccount = new Savings(nickName, accountNumber);
                        myBank.AddAccount(myAccount);
                        break;
                    case "3":
                        foreach (Account account in myBank.ListOfAccounts)
                        {
                            double currentBalance = account.GetBalance();
                            Console.WriteLine($"Your current balance of {account.NickName} is {currentBalance:C2}");
                        }
                        break;
                    case "4":
                        myAccount = myBank.SelectAccount();
                        myAccount.Withdraw();
                        Console.WriteLine($"You withdrew $10.00 from {myAccount.NickName}");
                        break;
                    case "5":
                        myAccount = myBank.SelectAccount();
                        myAccount.Deposit();
                        Console.WriteLine($"You deposited $50.00 to {myAccount.NickName}");
                        break;
                    case "6":
                        Console.WriteLine("Thank you for banking with us");
                        keepBanking = false;
                        break;
                    default:
                        Console.WriteLine("Invalid entry");
                        break;
                }

                Console.WriteLine("press any key to continue");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
