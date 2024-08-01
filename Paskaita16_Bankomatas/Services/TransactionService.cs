using Paskaita16_Bankomatas.Models;
using Paskaita16_Bankomatas.Services.Interfaces;
using System.Text.Json;

namespace Paskaita16_Bankomatas.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly ICardService _cardService;
        private readonly IUserInterface _userInterface;
        private readonly string _transactionFilePath;

        public TransactionService(ICardService cardService, IUserInterface userInterface, string transactionFilePath)
        {
            _cardService = cardService;
            _userInterface = userInterface;
            _transactionFilePath = transactionFilePath;
        }

        public void WithdrawCash(Guid id)
        {
            _userInterface.DisplayPromptForWithdraw();
            int amount = _userInterface.PromptForWithdraw();

            if (_cardService.IsValidAmount(id, amount))
            {
                if (TryWithdrawCash(id, amount))
                {
                    Console.WriteLine($"Isimta {amount} Eur");
                }
            }
        }

        public bool TryWithdrawCash(Guid id, decimal amount)
        {
            var cards = _cardService.ReadCardsInfo();

            Card? card = cards.FirstOrDefault(card => card.Id == id);

            if (card == null)
            {
                throw new ArgumentException($"Card with ID {id} not found.");
            }
            else
            {
                card.Balance -= amount;
                _cardService.SaveCardsInfo(cards);

                var transaction = new Transaction
                (
                    id,
                    amount,
                    DateTime.Now,
                    "Withdraw"
                );
                SaveTransaction(transaction);

                return true;
            }
        }

        public void SaveTransaction(Transaction transaction)
        {
            List<Transaction> transactions = LoadTransactions();
            transactions.Add(transaction);

            var json = JsonSerializer.Serialize(transactions);
            try
            {
                using (var writer = new StreamWriter(_transactionFilePath))
                {
                    writer.Write(json);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e}");
            }
        }

        public List<Transaction> LoadTransactions()
        {
            if (!File.Exists(_transactionFilePath))
                return new List<Transaction>();

            string jsonString = File.ReadAllText(_transactionFilePath);
            return JsonSerializer.Deserialize<List<Transaction>>(jsonString) ?? new List<Transaction>();
        }

        public void DisplayTransactions(Guid id)
        {
            var transactions = GetTransactionsForId(id);

            if (transactions.Count == 0)
            {
                Console.WriteLine("Transakciju nerasta.");
                return;
            }

            Console.WriteLine("Transakcijos:");
            Console.WriteLine("----------------");

            foreach (var transaction in transactions)
            {
                Console.WriteLine($"{transaction.Date:yyyy-MM-dd HH:mm} -> {transaction.Type} {transaction.Amount} Eur");
            }
        }

        private List<Transaction> GetTransactionsForId(Guid id)
        {
            return LoadTransactions().Where(t => t.CardId == id)
                                    .OrderByDescending(t => t.Date)
                                    .Take(5)
                                    .ToList();
        }
    }
}
