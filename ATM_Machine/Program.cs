using System;
using System.Collections.Generic;

namespace ATM_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            //Account atm = new Account();
            List<Account> accounts = new List<Account>();
            
            Checking myChecking = new Checking();
            Savings mySavings = new Savings();

            accounts.Add(myChecking);
            accounts.Add(mySavings);

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
                Console.WriteLine("5. Exit");

                string atmChoice = Console.ReadLine();

                switch (atmChoice)
                {
                    case "1":
                        //double currentBalance = atm.GetBalance();

                        foreach(var account in accounts)
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
