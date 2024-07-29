namespace Paskaita15_Kartojimas
{
    public class Program
    {
        static void Main(string[] args)
        {
            IMyLogger fileLogger = new FileMyLogger("text.txt");
            ConsoleMyLogger consoleLogger = new ConsoleMyLogger();
            var bufferedFileLogger = new BufferedFileLogger("text.txt", 10);

            var loggers = new List<IMyLogger> { fileLogger, consoleLogger, bufferedFileLogger };
            OrderService orderService = new OrderService(loggers);

            orderService.LogEvent += (sender, args) =>
            {
                Console.WriteLine($"[Timestamp] {args.Message}");
            };

            orderService.PlaceOrder();
        }
    }

    #region ***** Model and Service Example *****

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

    // Logger projektas
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

    //public class MyLoggerProgram
    //{
    //    static void A_Main(string[] args)
    //    {
    //        var bufferedFileLogger = new BufferedFileLogger("text.txt", 10);

    //        var loggers = new List<IMyLogger> { bufferedFileLogger };
    //        OrderService orderService = new OrderService(loggers);

    //        orderService.LogEvent += (sender, message) => Console.WriteLine($"Log {message}");
    //        var order = orderService.PlaceOrder();
    //    }
    //}
}
