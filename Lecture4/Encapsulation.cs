using System;
using System.Collections.Generic;

namespace Lecture4
{
    public class BankAccount
    {
        private string accountNumber;
        private decimal balance;

        public string AccountNumber
        {
            get { return accountNumber; }
            set
            {
                // Add validation logic if needed
                accountNumber = value;
            }
        }
        public decimal Balance
        {
            get { return balance; }
            private set
            {
                // Ensure the balance is not set directly, but only through methods
                if (value >= 0)
                {
                    balance = value;
                }
                else
                {
                    Console.WriteLine("Invalid balance.");
                }
            }
        }
        public BankAccount(string accountNumber)
        {
            AccountNumber = accountNumber;
            Balance = 0;
        }
        public void Deposit(decimal amount)
        {
            // Perform validation or other logic before updating the balance
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited ${amount}. New balance: ${Balance}");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount.");
            }
        }
        public void Withdraw(decimal amount)
        {
            // Perform validation or other logic before updating the balance
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn ${amount}. New balance: ${Balance}");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount or insufficient funds.");
            }
        }
    }

    public class Customer
    {
        private string name;
        private List<BankAccount> accounts;

        public string Name
        {
            get { return name; }
            set
            {
                // Add validation logic if needed
                name = value;
            }
        }

        public IReadOnlyList<BankAccount> Accounts
        {
            get { return accounts; }
        }

        public Customer(string name)
        {
            Name = name;
            accounts = new List<BankAccount>();
        }

        public void AddAccount(BankAccount account)
        {
            // Add validation or other logic before adding an account
            accounts.Add(account);
            Console.WriteLine($"{Name} added a new account: {account.AccountNumber}");
        }

        public void DisplayAccountDetails()
        {
            Console.WriteLine($"{Name}'s Account Details:");
            foreach (var account in accounts)
            {
                Console.WriteLine($"Account Number: {account.AccountNumber}, Balance: ${account.Balance}");
            }
        }
    }

    class Test
    {
        static void Main1()
        {
            // Create a customer
            Customer johnDoe = new Customer("John Doe");

            // Create and add bank accounts
            BankAccount account1 = new BankAccount("123456");
            BankAccount account2 = new BankAccount("789012");

            johnDoe.AddAccount(account1);
            johnDoe.AddAccount(account2);

            // Deposit and withdraw from accounts
            account1.Deposit(1000);
            account2.Deposit(500);

            account1.Withdraw(200);
            account2.Withdraw(100);

            // Display account details
            johnDoe.DisplayAccountDetails();
        }
    }

}
