using System;
using System.Collections.Generic;

public class BankAccount
{
    private static int nextAccountId = 1000;
    private int accountId;
    private string customerName;
    private decimal balance;
    private List<string> transactions;

    public BankAccount(string customerName, decimal initialBalance)
    {
        this.accountId = nextAccountId++;
        this.customerName = customerName;
        this.balance = initialBalance >= 0 ? initialBalance : 0;
        this.transactions = new List<string>();
        
        if (initialBalance > 0)
        {
            transactions.Add($"Initial deposit: +${initialBalance:F2} | Balance: ${this.balance:F2} | {DateTime.Now}");
        }
        else
        {
            transactions.Add($"Account opened with $0.00 | {DateTime.Now}");
        }
    }

    public int AccountId { get { return accountId; } }
    public string CustomerName { get { return customerName; } }
    public decimal Balance { get { return balance; } }
    public List<string> Transactions { get { return new List<string>(transactions); } }

    public bool Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Error: Deposit amount must be positive.");
            transactions.Add($"Failed deposit attempt: ${amount:F2} (Invalid amount) | {DateTime.Now}");
            return false;
        }

        balance += amount;
        transactions.Add($"Deposit: +${amount:F2} | Balance: ${balance:F2} | {DateTime.Now}");
        Console.WriteLine($"Successfully deposited ${amount:F2}. New balance: ${balance:F2}");
        return true;
    }

    public bool Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Error: Withdrawal amount must be positive.");
            transactions.Add($"Failed withdrawal attempt: ${amount:F2} (Invalid amount) | {DateTime.Now}");
            return false;
        }

        if (amount > balance)
        {
            Console.WriteLine($"Error: Insufficient funds. Attempted to withdraw ${amount:F2}, but balance is only ${balance:F2}");
            transactions.Add($"Failed withdrawal attempt: -${amount:F2} (Insufficient funds) | Balance: ${balance:F2} | {DateTime.Now}");
            return false;
        }

        balance -= amount;
        transactions.Add($"Withdrawal: -${amount:F2} | Balance: ${balance:F2} | {DateTime.Now}");
        Console.WriteLine($"Successfully withdrew ${amount:F2}. New balance: ${balance:F2}");
        return true;
    }

    public void DisplayAccountInfo()
    {
        Console.WriteLine($"\nAccount Information");
        Console.WriteLine($"Account ID: {accountId}");
        Console.WriteLine($"Customer Name: {customerName}");
        Console.WriteLine($"Current Balance: ${balance:F2}");
        Console.WriteLine($"Total Transactions: {transactions.Count}");
    }

    public void DisplayTransactionHistory()
    {
        Console.WriteLine($"\nTransaction History for {customerName} (Account #{accountId})");
        if (transactions.Count == 0)
        {
            Console.WriteLine("No transactions found.");
        }
        else
        {
            for (int i = 0; i < transactions.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {transactions[i]}");
            }
        }
    }
}