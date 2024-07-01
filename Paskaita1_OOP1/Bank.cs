namespace Paskaita1_OOP1
{
    internal class Bank
    {
        public Bank()
        {
            // initialization of a new empty list
            Accounts = new List<Account>();
        }

        public List<Account> Accounts { get; set; }

        public void AddMoney(string owner, decimal amount)
        {
            foreach (var acc in Accounts)
            {
                if(acc.Owner == owner)
                {
                    acc.Balance += amount;
                }
            }
        }
    }
}
