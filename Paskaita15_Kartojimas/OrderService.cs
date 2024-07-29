namespace Paskaita15_Kartojimas
{
    public class OrderService : IOrderService
    {
        private readonly List<IMyLogger> _loggers;

        public OrderService(IEnumerable<IMyLogger> loggers)// Priklausomybių injekcija per konstruktorių
        {
            _loggers = new List<IMyLogger>(loggers ?? Enumerable.Empty<IMyLogger>());
            _loggers.ForEach(logger => LogEvent += logger.Log);
        }

        //public delegate void OrderServiceLogHandler(string message);
        //public event OrderServiceLogHandler Logger = new OrderService(new List<IMyLogger>()).Log;

        public event Action<string> LogEvent;
        //public event EventHandler<string> LogEvent;

        public Order PlaceOrder()
        {
            // Kažkokia biznio logika
            var order = new Order(0.1, 100);
            LogEvent?.Invoke($"Order has been placed. Price={order.Price}, Ammount={order.Amount} ");
            return order;
        }
    }
}
