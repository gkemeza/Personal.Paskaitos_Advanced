namespace Paskaita14_Interfaces
{
    internal class Paypal : IPayment
    {
        public bool MakePayment(decimal money)
        {
            Console.WriteLine($"Payment made via Paypal: {money} Eur");
            return true;
        }
    }
}
