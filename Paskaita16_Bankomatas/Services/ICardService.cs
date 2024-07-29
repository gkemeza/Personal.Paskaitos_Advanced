namespace Paskaita16_Bankomatas.Services
{
    public interface ICardService
    {
        bool VerifyId();
        bool VerifyPin();
    }
}