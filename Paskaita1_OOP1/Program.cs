namespace Paskaita1_OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer();

            computer.Name = "Samsung";
            computer.RAM = 16;
            computer.CPU = "Intel";
            computer.GraphicsCard = "Nvidia Geforce 1080";
            computer.BuildDate = new DateTime(2020, 10, 3);

            Computer computer1 = new Computer("Asus1", "AMD", "AMD", 8, true);
            Computer computer2 = new Computer("Asus2", "AMD", "AMD", 4, false);

            List<Computer> computers = new List<Computer>();
            computers.Add(computer);
            computers.Add(computer1);
            computers.Add(computer2);

            foreach (var comp in computers)
            {
                //comp.PrintInfo();
                //Console.WriteLine(comp.IsEnoughRAM());
                //Console.WriteLine(comp);
                //Console.WriteLine("----------------------");
            }

            // paprasta kompozicija
            Car car = new Car("Kia");
            car.Model = "Test";
            car.Engine = new Engine();
            car.Engine.Liters = 5;
            car.Engine.Type = "Dysel";

            // lengviau skaitomas budas
            // bet geriau per konstruktoriu (tam jis ir yra)
            Car car2 = new Car("Audi")
            {
                Model = "Test",
                Engine = new Engine()
                {
                    Liters = 5,
                    Type = "Dysel"
                },
                Wheels = new List<Wheel>
                {
                    new Wheel
                    {
                        Brand = "Michelin",
                        Size = 19
                    },
                    new Wheel
                    {
                        Brand = "Michelin",
                        Size = 19
                    },
                    new Wheel
                    {
                        Brand = "Hankook",
                        Size = 19
                    },
                    new Wheel
                    {
                        Brand = "Hankook",
                        Size = 19
                    }
                }
            };

            // pakeicia pirmo rato dydi
            car2.Wheels[0].Size = 20;

            //foreach (var wheel in Wheels)
            //{

            //}

            // #1
            //Person person = new Person("Jonas", 99);
            //Console.WriteLine($"{person.Name} is {person.Age} years old");
            //Person person2 = new Person("Jonas", 99, 190.5);
            //Console.WriteLine($"{person2.Name} is {person2.Age} years old and {person2.Height}cm tall");

            // #2
            //School school = new School("Licejus", "Vilnius", 550);
            //Console.WriteLine($"Mokykla: {school.Name}, miestas: {school.City}, mokiniu sk.: {school.NumberOfStudents}");

            // #3
            Book book = new Book("Computer Systems: A Programmer's Perspective", "Randal E. Bryant, David R. O'Hallaron", 2015, "USA");
            Console.WriteLine($"{book.Title}\n{book.AuthorName}\n{book.PublicationYear}\n{book.CountryOfPublication}\n");
            Book book2 = new Book("Structure and Interpretation of Computer Programs", "Harold Abelson, Gerald J. Sussman, Julie Sussman", 1984, "USA");
            Console.WriteLine($"{book2.Title}\n{book2.AuthorName}\n{book2.PublicationYear}\n{book2.CountryOfPublication}\n");
            var books = new List<Book>
            {
                book,
                book2
            };

            var filteredBooks = FilterByAuthorName(books, "Randal E. Bryant, David R. O'Hallaron");
            foreach (var item in filteredBooks)
            {
                Console.WriteLine(item.Title);
            }

            // #4

        }

        // #3
        public static List<Book> FilterByAuthorName(List<Book> books, string authorName)
        {
            var filteredBooks = new List<Book>();
            foreach (var book in books)
            {
                if (book.AuthorName == authorName)
                {
                    filteredBooks.Add(book);
                }
            }
            return filteredBooks;
        }
    }
}
