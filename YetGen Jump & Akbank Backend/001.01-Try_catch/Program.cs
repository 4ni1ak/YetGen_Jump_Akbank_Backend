using System;
using System.Collections.Generic;

namespace InsecureBank
{
    class Program
    {
        static Dictionary<string, double> accountOwners = new Dictionary<string, double>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Welcome to the Insecure Bank!");
                Console.WriteLine("1. Create an Account");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Check Balance");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
                    continue;
                }

                try
                {
                    switch (choice)
                    {
                        case 1:
                            CreateAccount();
                            break;
                        case 2:
                            DepositMoney();
                            break;
                        case 3:
                            WithdrawMoney();
                            break;
                        case 4:
                            CheckBalance();
                            break;
                        case 5:
                            Console.WriteLine("Thank you for using the Insecure Bank!");
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please enter a valid option (1-5).");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("An error occurred.");
                }
            }
        }

        static void CreateAccount()
        {
            try
            {
                Console.Write("Enter your name: ");
                string ownerName = Console.ReadLine();

                if (!accountOwners.ContainsKey(ownerName))
                {
                    accountOwners.Add(ownerName, 0.0);
                    Console.WriteLine("Account created successfully!");
                }
                else
                {
                    Console.WriteLine("Account already exists.");
                }
            }
            catch
            {
                Console.WriteLine("An error occurred.");
            }
        }

        static void DepositMoney()
        {
            try
            {
                Console.Write("Enter your name: ");
                string ownerName = Console.ReadLine();

                if (!accountOwners.ContainsKey(ownerName))
                {
                    Console.WriteLine("Account not found. Please create an account first.");
                    return;
                }

                Console.Write("Enter the amount to deposit: ");
                double amount;
                if (!double.TryParse(Console.ReadLine(), out amount))
                {
                    Console.WriteLine("Invalid amount. Please enter a valid number.");
                    return;
                }

                accountOwners[ownerName] += amount;
                Console.WriteLine($"Deposited ${amount}. New balance: ${accountOwners[ownerName]}");
            }
            catch
            {
                Console.WriteLine("An error occurred.");
            }
        }

        static void WithdrawMoney()
        {
            try
            {
                Console.Write("Enter your name: ");
                string ownerName = Console.ReadLine();

                if (!accountOwners.ContainsKey(ownerName))
                {
                    Console.WriteLine("Account not found. Please create an account first.");
                    return;
                }

                Console.Write("Enter the amount to withdraw: ");
                double amount;
                if (!double.TryParse(Console.ReadLine(), out amount))
                {
                    Console.WriteLine("Invalid amount. Please enter a valid number.");
                    return;
                }

                if (accountOwners[ownerName] >= amount)
                {
                    accountOwners[ownerName] -= amount;
                    Console.WriteLine($"Withdrawn ${amount}. New balance: ${accountOwners[ownerName]}");
                }
                else
                {
                    Console.WriteLine("Insufficient funds.");
                }
            }
            catch
            {
                Console.WriteLine("An error occurred.");
            }
        }

        static void CheckBalance()
        {
            try
            {
                Console.Write("Enter your name: ");
                string ownerName = Console.ReadLine();

                if (!accountOwners.ContainsKey(ownerName))
                {
                    Console.WriteLine("Account not found. Please create an account first.");
                    return;
                }

                Console.WriteLine($"Your balance is ${accountOwners[ownerName]}");
            }
            catch
            {
                Console.WriteLine("An error occurred.");
            }
        }
    }
}
