using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<int, BankAccount> accounts = new Dictionary<int, BankAccount>();

    static void Main()
    {
        string command;
        while ((command = Console.ReadLine()) != "End")
        {
            ProcessCommand(command);
        }
    }

    static void ProcessCommand(string command)
    {
        string[] cmdArgs = command.Split();
        string cmdType = cmdArgs[0];

        switch (cmdType)
        {
            case "Create":
                CreateAccount(cmdArgs);
                break;
            case "Deposit":
                Deposit(cmdArgs);
                break;
            case "Withdraw":
                Withdraw(cmdArgs);
                break;
            case "Print":
                Print(cmdArgs);
                break;
            default:
                Console.WriteLine("Invalid command");
                break;
        }
    }

    static void CreateAccount(string[] cmdArgs)
    {
        int accountId = int.Parse(cmdArgs[1]);

        if (accounts.ContainsKey(accountId))
        {
            Console.WriteLine("Account already exists");
        }
        else
        {
            BankAccount newAccount = new BankAccount(accountId);
            accounts.Add(accountId, newAccount);
        }
    }

    static void Deposit(string[] cmdArgs)
    {
        int accountId = int.Parse(cmdArgs[1]);
        decimal amount = decimal.Parse(cmdArgs[2]);

        if (accounts.ContainsKey(accountId))
        {
            accounts[accountId].Deposit(amount);
        }
        else
        {
            Console.WriteLine("Account does not exist");
        }
    }

    static void Withdraw(string[] cmdArgs)
    {
        int accountId = int.Parse(cmdArgs[1]);
        decimal amount = decimal.Parse(cmdArgs[2]);

        if (accounts.ContainsKey(accountId))
        {
            if (accounts[accountId].Balance >= amount)
            {
                accounts[accountId].Withdraw(amount);
            }
            else
            {
                Console.WriteLine("Insufficient balance");
            }
        }
        else
        {
            Console.WriteLine("Account does not exist");
        }
    }

    static void Print(string[] cmdArgs)
    {
        int accountId = int.Parse(cmdArgs[1]);

        if (accounts.ContainsKey(accountId))
        {
            Console.WriteLine($"Account ID{accountId}, balance {accounts[accountId].Balance:F2}");
        }
        else
        {
            Console.WriteLine("Account does not exist");
        }
    }
}