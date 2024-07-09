namespace Paskaita5_AccessModifiers.Exercises
{
    public class SavingsAccount : BankAccount
    {
        public SavingsAccount(decimal interestRate)
        {
            InterestRate = interestRate;
        }

        private decimal InterestRate { get; set; }

        public void CalculateInterestRate()
        {
            SetBalance(Balance + (InterestRate / 100 * Balance));
        }
    }
}
