using Paskaita16_Bankomatas.Models;

namespace Paskaita16_Bankomatas.Services
{
    public interface ITransactionService
    {
        bool WithdrawCash();
        bool CheckBalance();
        List<Transaction> GetPastTransactions();
    }
}
