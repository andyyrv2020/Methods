namespace AddingMethodToBankAccount
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            BankAccount acc= new BankAccount(1);

            acc.ID = 1;
            acc.Deposit(15);
            acc.Withdraw(15);

            Console.WriteLine(acc.ToString());

        }
    }
}