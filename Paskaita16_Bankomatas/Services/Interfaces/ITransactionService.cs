using Paskaita16_Bankomatas.Models;

namespace Paskaita16_Bankomatas.Services.Interfaces
{
    public interface ITransactionService
    {
        void WithdrawCash(Guid id);
        List<Transaction> LoadTransactions();
        void DisplayTransactions(Guid id);
    }
}
