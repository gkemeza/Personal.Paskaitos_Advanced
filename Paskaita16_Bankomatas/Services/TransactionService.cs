using Paskaita16_Bankomatas.Models;

namespace Paskaita16_Bankomatas.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly ICardService _cardService;
        private readonly IUserInterface _userInterface;
        //private readonly List<Transaction> _transactions;

        List<Transaction> PastTransactions { get; set; }

        public TransactionService(ICardService cardService, IUserInterface userInterface)
        {
            _cardService = cardService;
            _userInterface = userInterface;
            //_transactions = new List<Transaction>();
        }

        private bool TryWithdrawCash(Guid id, decimal amount)
        {
            var card = _cardService.GetCard(id);

            if (card == null || card.Balance < amount)
            {
                return false;
            }

            card.Balance -= amount;
            return true;
        }

        public void WithdrawCash(Guid id)
        {
            _userInterface.DisplayPromptForWithdraw();
            int amount = _userInterface.PromptForWithdraw();

            if (TryWithdrawCash(id, amount))
            {
                Console.WriteLine($"Isimta {amount} Eur");
            }
        }

        public List<Transaction> GetPastTransactions()
        {
            throw new NotImplementedException();
        }
    }
}
