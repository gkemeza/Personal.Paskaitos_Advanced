namespace Paskaita1_OOP1
{
    internal class Account
    {
        public Account(string owner)
        {
            Owner = owner;
            Balance = 0;
        }

        public string Owner { get; set; }
        public decimal Balance { get; set; }
    }
}
