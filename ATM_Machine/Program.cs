﻿using System;
using System.Collections.Generic;

namespace ATM_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            Account myAccount = new Account();

            Bank myBank = new Bank();

            // List<Account> ListofAccounts = new List<Account>();

            Checking checkingAccount = new Checking()
            {
                AccountNumber = "C12-345",
                NickName = "First Checking",
            };

            //ListofAccounts.Add(checkingAccount);

            //ListofAccounts.Add(new Savings()
            //{
            //    AccountNumber = "S89-212",
            //    NickName = "Goal Savings"
            //});

            Console.WriteLine("Welcome to ATM Machine!");

            bool keepBanking = true;
            while (keepBanking)
            {
                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("1. Check balance");
                Console.WriteLine("2. Withdraw $10");
                Console.WriteLine("3. Deposit $50");
                Console.WriteLine("4. Exit");
                Console.WriteLine("5. Add checking account");
                Console.WriteLine("6. Add savings account");

                string accountChoice = Console.ReadLine();

                switch (accountChoice)
                {
                    case "1":
                        foreach (Account account in myBank.ListofAccounts)
                        {
                            double currentBalance = account.GetBalance();
                            Console.WriteLine($"Your current balance of {account.NickName} is {currentBalance:C2}");
                        }
                        break;
                    case "2":
                        //account.Withdraw();
                        //Console.WriteLine("You withdrew $10");
                        //break;
                    case "3":
                        //account.Deposit();
                        //Console.WriteLine("You deposited $50");
                        //break;
                    case "4":
                        Console.WriteLine("Thank you for banking with us.");
                        keepBanking = false;
                        break;
                    case "5":
                        Console.WriteLine("What is your nickname for your checking account?");
                        string nickName = Console.ReadLine();
                        Console.WriteLine("What is the account number for your checking account?");
                        string accountNumber = Console.ReadLine();
                        myAccount = new Checking(nickName, accountNumber);
                        myBank.AddAccount(myAccount);
                        break;
                    case "6":
                        Console.WriteLine("What is your nickname for your savings account?");
                        nickName = Console.ReadLine();
                        Console.WriteLine("What is the account number for your savings account?");
                        accountNumber = Console.ReadLine();
                        myAccount = new Savings(nickName, accountNumber);
                        myBank.AddAccount(myAccount);
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