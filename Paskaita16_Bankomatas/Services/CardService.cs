using Paskaita16_Bankomatas.Models;
using System.Text.Json;

namespace Paskaita16_Bankomatas.Services
{
    public class CardService : ICardService
    {
        private readonly string _cardFilePath;

        public CardService(string cardFilePath)
        {
            _cardFilePath = cardFilePath;
        }

        private void SaveCardInfo(Card card)
        {
            File.AppendAllText(_cardFilePath, JsonSerializer.Serialize(card) + Environment.NewLine);
        }

        public void SaveCardsInfo(List<Card> cards)
        {
            var lines = cards.Select(card => JsonSerializer.Serialize(card));
            File.WriteAllLines(_cardFilePath, lines);
        }

        public List<Card> ReadCardsInfo()
        {
            var cards = new List<Card>();
            try
            {
                if (File.Exists(_cardFilePath))
                {
                    string[] lines = File.ReadAllLines(_cardFilePath);
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
                new Card ( Guid.NewGuid(), 1234, 500m),
                new Card ( Guid.NewGuid(), 1234, 700m),
                new Card ( Guid.NewGuid(), 1234, 1000m)
            };

            cards.ForEach(SaveCardInfo);
        }

    }
}
