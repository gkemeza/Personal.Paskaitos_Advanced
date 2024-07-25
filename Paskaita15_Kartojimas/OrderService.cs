namespace Paskaita15_Kartojimas
{
    public class OrderService : IOrderService
    {
        private readonly List<IMyLogger> _loggers;

        public OrderService(IEnumerable<IMyLogger> loggers)// Priklausomybių injekcija per konstruktorių
        {
            _loggers = new List<IMyLogger>(loggers);
        }

        public Order PlaceOrder()
        {
            // Kažkokia biznio logika
            var order = new Order(0.1, 100);
            Log($"Order has been placed. Price={order.Price}, Ammount={order.Amount} ");
            return order;
        }

        public event EventHandler<Order> OrderPlaced;
        private void Log(string message) => _loggers.ForEach(logger => logger.Log(message));
    }
}
