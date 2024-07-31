namespace Paskaita16_Bankomatas.Models
{
    public class Transaction
    {
        public Guid CardId { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; }
        //List<Banknote> Banknotes { get; set; }

        public Transaction()
        {
        }

        public Transaction(Guid id, decimal amount, DateTime date, string type)
        {
            CardId = id;
            Amount = amount;
            Date = date;
            Type = type;
        }
    }
}
