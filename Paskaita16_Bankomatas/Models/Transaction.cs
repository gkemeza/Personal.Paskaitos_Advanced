namespace Paskaita16_Bankomatas.Models
{
    public class Transaction
    {
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Action { get; set; }
        List<Banknote> Banknotes { get; set; }

        public Transaction(decimal amount, DateTime date, string action)
        {
            Amount = amount;
            Date = date;
            Action = action;
        }
    }
}
