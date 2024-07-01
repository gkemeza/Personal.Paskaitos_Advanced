namespace Paskaita2_MethodsInClasses
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region
            //Computer computer = new Computer
            //{
            //    Apps =
            //    {
            //        new App
            //        {
            //            Name = "app1",
            //            Size = 100
            //        },
            //        new App
            //        {
            //            Name = "app2",
            //            Size = 200
            //        },
            //        new App
            //        {
            //            Name = "app3",
            //            Size = 600
            //        },
            //        new App
            //        {
            //            Name = "app4",
            //            Size = 4000
            //        },
            //        new App
            //        {
            //            Name = "app5",
            //            Size = 500
            //        }
            //    }
            //};

            //computer.PrintInfo();
            //Console.WriteLine("---------------------");
            //computer.PrintInfo();

            // #0
            //var manoKlase = new ManoKlase();
            //manoKlase.ManoMetodas();
            //ManoKlase.ManoStatinisMetodas();

            // #1
            //var manoKlase2 = new ManoKlase2();
            //manoKlase2.PrintText();
            #endregion

            #region
            //var manoKlase2 = new ManoKlase2();
            //manoKlase2.ChangeText();

            //var manoKlaseAntras = new ManoKlase2();
            //Console.WriteLine("-> Pradine reiksme: ");
            //manoKlaseAntras.PrintText();
            //Console.WriteLine("-> Nauja reiksme: ");
            //manoKlase2.PrintText();

            //Console.WriteLine("-> Pradine reiksme (perkurus objekta): ");
            //// galima perkurti objekta (pradiniam objekte - viskas prarandama)!
            //manoKlase2 = new ManoKlase2();
            //manoKlase2.PrintText();

            // 2.
            //var order = new Order();
            //order.PrintOrder();
            #endregion

            #region
            // #1
            //var numbers = new Numbers();
            //numbers.AddNumber(8);
            //numbers.PrintNumbers();

            // #2
            //var rectangle = new Rectangle(4, 5);
            //Console.WriteLine($"Area: {rectangle.GetArea()}");
            //Console.WriteLine($"Perimeter: {rectangle.GetPerimeter()}");

            // #3
            //var circle = new Circle(4);
            //Console.WriteLine($"Area: {circle.GetArea()}");
            //Console.WriteLine($"Perimeter: {circle.GetPerimeter()}");

            // #4
            //var library = new Library();
            //var book = new Book();
            //library.AddBook(book);
            //library.RemoveBook(book);

            // #5
            //var playlist = new Playlist();
            //var song = new Song();
            //playlist.AddSong(song);
            //playlist.RemoveSong(song);

            // #6
            //var movie = new Movie("Mad Max: Fury Road", "Action", 8.1);
            //Console.WriteLine($"Should I watch it: {movie.CanIWatchIt()}");

            // #7
            //var book2 = new Book2("Hamlet", "William Shakespeare", 289);
            //Console.WriteLine($"~{book2.HowLongToFinish()} hrs to finish");

            // #8
            //var computer2 = new Computer2("MSI", "Aegis R", 8, 500);
            //Console.WriteLine($"Enough RAM: {computer2.IsEnoughRAM(8)}");

            #endregion
        }
    }

    // metodu uzduotys
    #region
    /*---------
    KLAUSIMAI sukonstravus metodą
        Kokį tikslą šis metodas turi pasiekti?
        Ar šis metodas atitinka klasės atsakomybes?
        Kokie duomenys reikalingi šiam metodui?
        Ar metodas turėtų grąžinti reikšmę? Jei taip, kokią ir kokio tipo?
        Ar metodas turi šalutinių efektų, pvz., keičia klasės būseną?
        Ar metodas turi būti prieinamas iš išorės klasės (public) ar tik klasės viduje (private)?
        Ar metodas pavadintas taip, kad būtų aišku, ką jis daro?
        Ar metodas turi būti ištestuotas atskirai?
        Ar metodas yra pakankamai bendras, kad būtų naudingas kitoms klasėms, ar jis yra specifinis šiai klasei?
        Ar galima metodą skaidyti į mažesnius, labiau specializuotus metodus?
        Ar metodas yra helper tipo, ty jam nereikalingas priėjimas prie klasės instance?
        Ar metodas turi išorinių priklausomybių?  Kaip šios priklausomybės gali paveikti metodo lankstumą ir testavimą?
        Ar metodas yra efektyvus? Ar jo našumas yra tinkamas numatytoms užduotims?
    */

    /*-------------------------------------------------------------------
    1. Ar šis metodas atitinka klasės atsakomybes?
    UŽDUOTIS: Pataisykite
    Ats.: Neatitinka klases atsakomybes, todel reikejo iskelti is klases (perkelti i klase, kurios atsakomybes sitas metodas atitinka)
    */
    public class Customer
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }

    // 1.
    public class RandomNumbers()
    {
        public static int GenerateRandomNumber()
        {
            Random random = new Random();
            return random.Next();
        }
    }

    /*-------------------------------------------------------------------
    2. Kokie duomenys reikalingi šiam metodui?
    UŽDUOTIS: Pataisykite
    Ats.: Nereikejo per parametrus nieko perduoti, nes galima tiesiai is properties paimti reikalingas reiksmes.
    */
    public class Order
    {
        public int OrderId { get; set; }
        public decimal Amount { get; set; }

        public void PrintOrder()
        {
            Console.WriteLine($"Processing order {OrderId} with amount {Amount} ");
        }
    }

    /*-------------------------------------------------------------------
         3. Ar metodas turėtų grąžinti reikšmę? Jei taip, kokią ir kokio tipo?
          UŽDUOTIS: Pataisykite
    Ats.: turi
         -------------------------------------------------------------------*/

    public class Calculator
    {
        // Blogas pavyzdys - metodas atlieka skaičiavimą, bet negrąžina reikšmės (buvo)
        public int Add(int a, int b)
        {
            return a + b;
        }
    }

    /*-------------------------------------------------------------------
       7. Ar galima metodą skaidyti į mažesnius, labiau specializuotus metodus?
       UŽDUOTIS: Pataisykite
       Ats.: ne, bet mano metodas sake gerai? (siaip dar truksta validacijos metode (pvz.: kad butu 'discountPercentage' > 0))
       + metodas yra pakankamai bendras (tipo nera specifinis šiai klasei?), todel galima iskelti is sitos klases
    */

    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public decimal CalculateDiscount(decimal discountPercentage)
        {
            return Price * discountPercentage / 100;
        }

        public decimal ApplyDiscount(decimal discount)
        {
            return Price - discount;
        }
    }
    #endregion
}