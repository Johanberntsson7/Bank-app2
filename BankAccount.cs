namespace Bank
{
    public class BankAccount
    {
        protected string ownerName;
        protected double balance;

        public BankAccount(string ownerName, double initialBalance)
        {
            this.ownerName = ownerName;
            this.balance = initialBalance;
        }
        public double GetBalance()
        {
            return balance;
        }
        public void Deposit(double amount)
        {
            balance += amount;
            Console.WriteLine($"{ownerName} satte in {amount} kr. Nytt saldo: {balance} kr.");
        }
        public void Withdraw(double amount)
{
    if (amount <= balance)
    {
        balance -= amount;
        Console.WriteLine($"{ownerName} tog ut {amount} kr. Nytt saldo: {balance} kr");
    }
    else
    {
        Console.WriteLine("Otillräckligt saldo!");
    }
}
    }
}