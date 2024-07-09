namespace Paskaita5_AccessModifiers.Exercises
{
    public class CheckingAccount : BankAccount
    {
        public CheckingAccount(decimal overdraftLimit)
        {
            OverdraftLimit = overdraftLimit;
        }

        private decimal OverdraftLimit { get; set; }

        public void Withdraw(decimal amount)
        {
            if (amount > OverdraftLimit)
            {
                throw new ArgumentOutOfRangeException("Negalima virsyti overdraft limit'o");
            }
            else if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("Negalima issiimti neigiamo skaiciaus");
            }
            SetBalance(Balance - amount);
        }
    }
}
