using System;

class Program
{
    static void Main()
    {
        // Пример за използване на класа Person
        Person person = new Person("Иван", 30);

        // Добавяне на банкови сметки
        person.Accounts.Add(new BankAccount { AccountNumber = "123456", Balance = 1000 });
        person.Accounts.Add(new BankAccount { AccountNumber = "789012", Balance = 2000 });

        // Изчисляване и извеждане на общия баланс
        double totalBalance = person.GetBalance();
        Console.WriteLine($"Общ баланс на {person.Name}: {totalBalance} лв.");
    }
}