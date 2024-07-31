using Paskaita16_Bankomatas.Models;

namespace Paskaita16_Bankomatas.Services
{
    public interface ICardService
    {
        decimal GetBalance(Guid id);
        public void SaveTestCards();
        public Card GetCard(Guid id);
        public bool IsCorrectId(Guid id);
        public bool IsCorrectPin(Guid id, int pin);
        public bool TryWithdrawCash(Guid id, decimal amount);
    }
}