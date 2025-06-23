using System;

namespace BankGameApp
{
    public class BankAccount
    {
        public string AccountHolder { get; }
        public double Balance { get; private set; } // private set we have used for when only if class should be able to change the balance.
        

        // Constructor for BankAccount
        public BankAccount(string accountHolder, double initialBalance)
        {
            AccountHolder = accountHolder;
            Balance = initialBalance;
        }

        // Method to deposit money into the account
        public bool Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be positive.");
                return false;
            }
            Balance += amount;
            return true;
        }

        // Method to withdraw money from the account
        public bool Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdraw amount must be positive.");
                return false;
            }
            if (amount > Balance)
            {
                Console.WriteLine("Insufficient funds.");
                return false;
            }
            Balance = Balance - amount;  
            return true;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
      
       
            var account1 = new BankAccount("Account1", 2000);
            var account2 = new BankAccount("Account2", 3000);

            Console.WriteLine("Starting Balances:");
            Console.WriteLine(account1.AccountHolder + ": " + account1.Balance.ToString("C"));
            Console.WriteLine(account2.AccountHolder + ": " + account2.Balance.ToString("C"));


            for (int round = 1; round <= 3; round++)
            {
                Console.WriteLine($"Round {round}:\n");

                // Account 1's turn

                Console.Write($"{account1.AccountHolder} Withdraw or Deposit (w/d): ");
                var action1 = Console.ReadLine()?.ToLower(); // tolower used for case insensitivity. Converts input to lowercase.
                if (action1 == "w")
                {
                    Console.Write("Amount to Withdraw: ");
                    if (double.TryParse(Console.ReadLine(), out double amount) && amount > 0)
                        account1.Withdraw(amount);
                    else
                        Console.WriteLine("Invalid amount.");
                }
                else if (action1 == "d")
                {
                    Console.Write("Amount to Deposit: ");
                    if (double.TryParse(Console.ReadLine(), out double amount) && amount > 0)
                        account1.Deposit(amount);
                    else
                        Console.WriteLine("Invalid amount.");
                }
                else
                {
                    Console.WriteLine("Invalid action.");
                }

                // Account 2's turn
                Console.Write($"{account2.AccountHolder} Withdraw or Deposit (w/d): ");
                var action2 = Console.ReadLine()?.ToLower(); 
                if (action2 == "w")
                {
                    Console.Write("Amount to Withdraw: ");
                    if (double.TryParse(Console.ReadLine(), out double amount) && amount > 0)
                        account2.Withdraw(amount);
                    else
                        Console.WriteLine("Invalid amount.");
                }
                else if (action2 == "d")
                {
                    Console.Write("Amount to Deposit: ");
                    if (double.TryParse(Console.ReadLine(), out double amount) && amount > 0)
                        account2.Deposit(amount);
                    else
                        Console.WriteLine("Invalid amount.");
                }
                else
                {
                    Console.WriteLine("Invalid action.");
                }

                Console.WriteLine($"Balances after Round {round}:");
                Console.WriteLine($"{account1.AccountHolder}: {account1.Balance:C}");
                Console.WriteLine($"{account2.AccountHolder}: {account2.Balance:C}\n");
            }

            // winner 
            Console.WriteLine("Game Over!");
            if (account1.Balance > account2.Balance)

                Console.WriteLine($"{account1.AccountHolder} wins with {account1.Balance:C}!");

            else if (account2.Balance > account1.Balance)
                Console.WriteLine($"{account2.AccountHolder} wins with {account2.Balance:C}!");
            else
                Console.WriteLine("It's a tie!");
        }
    }
}
