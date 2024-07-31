using Paskaita16_Bankomatas.Models;
using System.Text.Json;

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
            File.AppendAllText(_filePath, JsonSerializer.Serialize(card) + Environment.NewLine);
        }

        private List<Card> ReadCardsInfo()
        {
            var cards = new List<Card>();
            try
            {
                if (File.Exists(_filePath))
                {
                    string[] lines = File.ReadAllLines(_filePath);
                    foreach (string line in lines)
                    {
                        if (!string.IsNullOrWhiteSpace(line))
                        {
                            Card card = JsonSerializer.Deserialize<Card>(line);
                            cards.Add(card);
                        }
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine($"Error: {e}");
            }

            return cards;
        }

        public void UpdateCardBalance()
        {

        }

        public Card GetCard(Guid id)
        {
            var cards = ReadCardsInfo();
            return cards.First(card => card.Id == id);
        }

        public bool IsCorrectId(Guid id)
        {
            var cards = ReadCardsInfo();
            return cards.Any(card => card.Id == id);
        }

        public bool IsCorrectPin(Guid id, int pin)
        {
            var cards = ReadCardsInfo();
            var card = cards.FirstOrDefault(card => card.Id == id);
            return card != null && card.Pin == pin;
        }

        public decimal GetBalance(Guid id)
        {
            List<Card> cards = ReadCardsInfo();
            Card card = cards.FirstOrDefault(x => x.Id == id);
            return card.Balance;
        }

        public void SaveTestCards()
        {
            var cards = new List<Card>
            {
                new Card ( Guid.Parse("6E75B40C-C95F-451F-9602-301801234567"), 1234, 500m),
                new Card ( Guid.Parse("F3E2187C-3C6E-44C9-A445-2B2871543210"), 1234, 700m),
                new Card ( Guid.NewGuid(), 1234, 1000m)
            };

            cards.ForEach(SaveCardInfo);
        }

    }
}
