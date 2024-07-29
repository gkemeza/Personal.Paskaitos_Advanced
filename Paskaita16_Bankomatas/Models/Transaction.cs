namespace Paskaita16_Bankomatas.Models
{
    public class Transaction
    {
        public decimal Amount { get; set; }
        public decimal Balance { get; set; }
        List<Banknote> Banknotes { get; set; }
        List<Transaction> PastTransactions { get; set; }

    }
}
