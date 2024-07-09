namespace Paskaita5_AccessModifiers.Exercises
{
    public class BankAccount
    {
        private decimal balance;

        protected decimal Balance
        {
            get { return balance; }
            private set { balance = value; }
        }

        public void SetBalance(decimal amount)
        {
            Balance = amount;
        }

        protected void PrintBalance()
        {
            Console.WriteLine($"Balansas: {balance}");
        }
    }
}
