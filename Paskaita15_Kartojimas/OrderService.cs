namespace Paskaita15_Kartojimas
{
    public class OrderService : IOrderService
    {
        private readonly List<IMyLogger> _loggers;

        public OrderService(IEnumerable<IMyLogger> loggers)// Priklausomybių injekcija per konstruktorių
        {
            _loggers = new List<IMyLogger>(loggers ?? Enumerable.Empty<IMyLogger>());
            _loggers.ForEach(logger => LogEvent += (sender, args) => logger.Log(args.Message));
        }

        //public event Action<string> LogEvent;

        //public delegate void OrderServiceLogHandler(object sender, LogEventArgs e);
        //public event OrderServiceLogHandler LogEvent;

        public event EventHandler<LogEventArgs> LogEvent;

        public Order PlaceOrder()
        {
            // Kažkokia biznio logika
            var order = new Order(0.1, 100);
            OnLogEvent($"Order has been placed. Price={order.Price}, Amount={order.Amount}"));
            return order;
        }

        private void OnLogEvent(string message)
        {
            LogEvent?.Invoke(this, new LogEventArgs(message));
        }
    }
}
