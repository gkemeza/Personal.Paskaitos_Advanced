using Paskaita16_Bankomatas.Models;

namespace Paskaita16_Bankomatas.Services
{
    public interface ICardService
    {
        bool VerifyId();
        bool VerifyPin();
        decimal GetBalance();
        public List<Card> ReadCardsInfo();
        public void SaveTestCards();
    }
}