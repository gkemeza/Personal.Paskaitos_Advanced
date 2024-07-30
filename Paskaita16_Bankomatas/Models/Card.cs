namespace Paskaita16_Bankomatas.Models
{
    public class Card
    {
        public Card(Guid id, int pin, decimal balance)
        {
            Id = id;
            Pin = pin;
            Balance = balance;
        }

        public Guid Id { get; set; }
        public int Pin { get; set; }
        public decimal Balance { get; set; }
    }
}
