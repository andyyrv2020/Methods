public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public List<BankAccount> Accounts { get; set; }

    // Конструктор за инициализация на обекта
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
        Accounts = new List<BankAccount>();
    }

    // Метод за изчисляване на общия баланс от всички сметки
    public double GetBalance()
    {
        double totalBalance = 0;

        foreach (var account in Accounts)
        {
            totalBalance += account.Balance;
        }

        return totalBalance;
    }
}
