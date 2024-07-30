using Paskaita16_Bankomatas.Models;

namespace Paskaita16_Bankomatas.Services
{
    public interface ITransactionService
    {
        void WithdrawCash(Guid id);
        List<Transaction> GetPastTransactions();
    }
}
