using System.Collections.Generic;

namespace Paskaita15_Kartojimas
{
    public class Program
    {
        static void Main(string[] args)
        {
            //IMyLogger logger = new ConsoleMyLogger();
            //IMyLogger logger2 = new FileMyLogger("text.txt");
            var bufferedFileLogger = new BufferedFileLogger("text.txt", 10);

            var loggers = new List<IMyLogger> { bufferedFileLogger };
            OrderService orderService = new OrderService(loggers);
            orderService.PlaceOrder();
        }
    }

    #region ***** Model and Service *****

    // tipine POCO/modelio klase - duomenu konteineriai
    // nereikia interface, geriau veikia abstract klases
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public string City { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string PostalCode { get; set; }
    }

    public interface ICustomerService
    {
        void AddCustomer(Customer customer);
        void DeleteCustomer(int id);
        void UpdateCustomer(Customer customer);
    }

    // serviso klases
    // servisu klases yra naudojamos apibrezti verslo logika ir operacijas, kurias reikia atlikti su POCO medeliais ar kitais duomenimis.
    // su servisais turetu buti naudojama interface

    public class CustomerService() : ICustomerService
    {
        public void AddCustomer(Customer customer)
        {
            // kazkokia biznio logika
        }

        public void UpdateCustomer(Customer customer)
        {
            // kazkokia biznio logika
        }

        public void DeleteCustomer(int id)
        {
            // kazkokia biznio logika
        }
    }

    #endregion

    // Loger projektas
    /*
     1. Pakeiskite pateiką programą taip, kad vietoje ConsoleMyLogger klasės būtų naudojamas FileMyLogger klasės objektas
     - Keisti galima tik Main metodą, visą kitą kodą palikti nepakeistą.
     - Galima pridėti naują klasę, bet nekeisti esamų. 
     */
    /*
    3 UŽDUOTIS:. Pakeiskite pateiką programą taip, kad PlaceOrder()
        būtu naudojama daugiau kaip vienas loggeris tuo pat metu (pvz ir ConsoleMyLogger ir FileMyLogger)
     */
    /*
     4 UŽDUOTIS:. Įgyvendinkite naują BufferedFileLogger klasę, kuri kauptų žurnalo įrašus atmintyje ir įrašytų juos į failą tik tada, 
       kai pasiekiamas tam tikras įrašų skaičius arba iškviečiamas specialus metodas Flush().
     */
    /*
    5 UŽDUOTIS (neprivaloma):. Modifikuokite OrderService klasę, kad ji naudotų įvykių modelį (event) vietoj tiesioginio Log metodo kvietimo. 
        Sukurkite LogEventArgs klasę ir leiskite išoriniams komponentams užsiprenumeruoti šiuos įvykius..
     */



    public record Order(double Price, double Amount); //modelis

    public interface IMyLogger
    {
        void Log(string message);
    }


    public class ConsoleMyLogger : IMyLogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class FileMyLogger : IMyLogger
    {
        private readonly string _filePath;

        public FileMyLogger(string filePath)
        {
            _filePath = filePath;
        }

        public void Log(string message)
        {
            try
            {
                File.AppendAllText(_filePath, message);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }

    public class BufferedFileLogger : IMyLogger
    {
        private readonly string _filePath;
        private readonly int _bufferSize;
        private readonly List<string> _messages = new List<string>();

        public BufferedFileLogger(string filePath, int bufferSize)
        {
            _filePath = filePath;
            _bufferSize = bufferSize;
        }

        public void Log(string message)
        {
            _messages.Add(message);

            if (_messages.Count >= _bufferSize)
            {
                Flush();
            }
        }

        private void Flush()
        {
            var fileLogger = new FileMyLogger(_filePath);
            _messages.ForEach(fileLogger.Log);
            _messages.Clear();
        }
    }

    public interface IOrderService
    {
        Order PlaceOrder();
    }

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

    public class LogEventArgs()
    {

    }

    public class MyLoggerProgram
    {
        static void A_Main(string[] args)
        {
            var bufferedFileLogger = new BufferedFileLogger("text.txt", 10);

            var loggers = new List<IMyLogger> { bufferedFileLogger };
            OrderService orderService = new OrderService(loggers);
            orderService.PlaceOrder();
        }
    }
}
