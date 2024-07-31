namespace Paskaita16_Bankomatas.Models
{
    public class Transaction
    {
        public Guid CardID { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; }
        //List<Banknote> Banknotes { get; set; }

        public Transaction(decimal amount, DateTime date, string action)
        {
            Amount = amount;
            Date = date;
            Type = action;
        }
    }
}
