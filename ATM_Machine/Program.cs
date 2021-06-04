using System;
using System.Collections.Generic;

namespace ATM_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank myBank = new Bank();

            Console.WriteLine("Welcome to ATM Machine");

            bool keepBanking = true;
            while (keepBanking)
            {
                Console.Clear();
                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("1. Check balance");
                Console.WriteLine("2. Withdraw $10");
                Console.WriteLine("3. Deposit $50");
                Console.WriteLine("4. Deposit A Specific Amount");
                Console.WriteLine("5. Create a Checking Account");
                Console.WriteLine("6. Create a Savings Account");
                Console.WriteLine("7. Delete an Account");
                Console.WriteLine("8. Exit");

                string atmChoice = Console.ReadLine();

                switch (atmChoice)
                {
                    case "1":
                        //double currentBalance = atm.GetBalance();

                        foreach(var account in myBank.ListOfAccounts)
                        {
                            double currentBalance = account.GetBalance();
                            Console.WriteLine($"Your current balance is: {currentBalance:C2}");
                        }

                        break;
                    case "2":
                        //atm.Withdraw();
                        Console.WriteLine("You withdrew $10");
                        break;
                    case "3":
                        //atm.Deposit();
                        Console.WriteLine("You deposited $50");
                        break;
                    case "4":
                        Console.WriteLine("Specify an amount to deposit:");
                        double amount = Convert.ToDouble(Console.ReadLine());
                        //atm.Deposit(amount);
                        Console.WriteLine($"You deposited {amount:C2}");
                        break;
                    case "5":
                        Console.WriteLine("Enter a nickname for this checking account: ");
                        string checkingName = Console.ReadLine();
                        Console.WriteLine("Enter an account number for this checking account: ");
                        string checkingAccountNumber = Console.ReadLine();
                        
                        Checking myChecking = new Checking(checkingName, checkingAccountNumber);
                        myBank.AddAccount(myChecking);
                        
                        break;
                    case "6":
                        Console.WriteLine("Enter a nickname for this savings account: ");
                        string savingsName = Console.ReadLine();
                        Console.WriteLine("Enter an account number for this savings account: ");
                        string savingsAccountNumber = Console.ReadLine();
                        
                        myBank.AddAccount(new Savings(savingsName, savingsAccountNumber));

                        break;
                    case "7":
                        Console.Clear();
                        Console.WriteLine("Choose an account to remove: ");
                        int index = 1;
                        foreach(var account in myBank.ListOfAccounts)
                        {
                            Console.WriteLine($"{index}. {account.NickName}");
                            index++;
                        }

                        int userChoice = Convert.ToInt32(Console.ReadLine());
                        myBank.RemoveAccount(userChoice - 1);

                        break;
                    case "8":
                        Console.WriteLine("Thank you for banking with us.");
                        keepBanking = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }

                Console.WriteLine("Press any key to continue");
                Console.ReadKey();


            } // end while

        }
    }
}
