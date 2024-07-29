namespace Paskaita16_Bankomatas.Models
{
    public class Card
    {
        public Guid Id { get; set; }
        public string Password { get; set; }
        public decimal Balance { get; set; }
    }
}
