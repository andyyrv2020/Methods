using System;

namespace AddingMethodToBankAccount
{
    public class BankAccount
    {
        private int id;
        private double balance;

        // Свойство за достъп до полето id
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        // Свойство за достъп до полето balance
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        // Конструктор за инициализация на обекта
        public BankAccount(int accountId)
        {
            id = accountId;
            balance = 0.0;
        }

        // Метод за депозиране на средства
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited {amount} to account {ID}. New balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount. Amount must be greater than zero.");
            }
        }

        // Метод за теглене на средства
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn {amount} from account {ID}. New balance: {Balance}");
            }
            else if (amount <= 0)
            {
                Console.WriteLine("Invalid withdrawal amount. Amount must be greater than zero.");
            }
            else
            {
                Console.WriteLine("Insufficient funds for withdrawal.");
            }
        }
    }
}