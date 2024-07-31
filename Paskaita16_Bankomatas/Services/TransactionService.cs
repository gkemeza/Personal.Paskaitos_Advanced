using Paskaita16_Bankomatas.Models;

namespace Paskaita16_Bankomatas.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly ICardService _cardService;
        private readonly IUserInterface _userInterface;

        public TransactionService(ICardService cardService, IUserInterface userInterface)
        {
            _cardService = cardService;
            _userInterface = userInterface;
        }

        public void WithdrawCash(Guid id)
        {
            _userInterface.DisplayPromptForWithdraw();
            int amount = _userInterface.PromptForWithdraw();

            if (_cardService.TryWithdrawCash(id, amount))
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
