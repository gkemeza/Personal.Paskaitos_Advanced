namespace Paskaita14_Interfaces
{
    internal class Shop
    {
        private readonly IPayment _payment;

        public Shop(IPayment payment)
        {
            _payment = payment;
        }

        public void Buying(decimal amount)
        {
            _payment.MakePayment(amount);
        }
    }
}
