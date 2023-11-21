class BankAccount
{
    public int Id { get; }
    public decimal Balance { get; private set; }

    public BankAccount(int id)
    {
        Id = id;
        Balance = 0;
    }

    public void Deposit(decimal amount)
    {
        Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        Balance -= amount;
    }
}