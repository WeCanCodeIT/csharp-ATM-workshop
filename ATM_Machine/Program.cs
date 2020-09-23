using Microsoft.VisualBasic;
using System;

namespace ATM_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            
            Console.WriteLine("Welcome to ATM Machine");

            bool keepBanking = true;
            while (keepBanking)
            {
                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("1. Check balance");
                Console.WriteLine("2. Withdraw $10");
                Console.WriteLine("3. Deposit $50");
                Console.WriteLine("4. Exit");

                string atmChoice = Console.ReadLine();

                switch (atmChoice)
                {
                    case "1":
                        double currentBalance = account.GetBalance();
                        Console.WriteLine($"Your current balance is {currentBalance:C2}");
                        break;
                    case "2":
                        account.Withdraw();
                        Console.WriteLine("You withdrew $10");
                        break;
                    case "3":
                        account.Deposit();
                        Console.WriteLine("You deposited $50");
                        break;
                    case "4":
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
