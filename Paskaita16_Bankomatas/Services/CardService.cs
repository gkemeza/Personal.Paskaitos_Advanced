using Paskaita16_Bankomatas.Models;

namespace Paskaita16_Bankomatas.Services
{
    public class CardService : ICardService
    {
        private readonly string _filePath;

        public CardService(string filePath)
        {
            _filePath = filePath;
        }

        public void SaveCardInfo(Card card)
        {
            string cardData = $"{card.Id},{card.Pin},{card.Balance}";
            File.AppendAllText(_filePath, cardData + Environment.NewLine);
        }

        public List<Card> ReadCardsInfo()
        {
            var cards = new List<Card>();

            try
            {
                if (File.Exists(_filePath))
                {
                    string[] lines = File.ReadAllLines(_filePath);
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 3)
                        {
                            Card card = new Card
                            (
                                Guid.Parse(parts[0]),
                                int.Parse(parts[1]),
                                decimal.Parse(parts[2])
                            );
                            cards.Add(card);
                        }
                    };
                }
            }
            catch (FileNotFoundException e)
            {
            }

            return cards;
        }

        public bool VerifyId()
        {
            throw new NotImplementedException();
        }

        public bool VerifyPin()
        {
            throw new NotImplementedException();
        }

        public decimal GetBalance()
        {
            throw new NotImplementedException();
        }

        public void SaveTestCards()
        {
            var cards = new List<Card>
            {
                new Card ( Guid.Parse("6E75B40C-C95F-451F-9602-301801234567"), 1234, 500m),
                new Card ( Guid.Parse("F3E2187C-3C6E-44C9-A445-2B2871543210"), 1234, 700m),
                new Card ( Guid.Parse("9A7B4C5D-E6F7-48A9-B0A1-234567890ABC"), 1234, 1000m)
            };

            cards.ForEach(SaveCardInfo);
        }


    }
}
