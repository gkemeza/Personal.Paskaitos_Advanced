namespace Paskaita1_OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // teorija
            #region
            //Computer computer = new Computer();

            //computer.Name = "Samsung";
            //computer.RAM = 16;
            //computer.CPU = "Intel";
            //computer.GraphicsCard = "Nvidia Geforce 1080";
            //computer.BuildDate = new DateTime(2020, 10, 3);

            //Computer computer1 = new Computer("Asus1", "AMD", "AMD", 8, true);
            //Computer computer2 = new Computer("Asus2", "AMD", "AMD", 4, false);

            //List<Computer> computers = new List<Computer>();
            //computers.Add(computer);
            //computers.Add(computer1);
            //computers.Add(computer2);

            //foreach (var comp in computers)
            //{
            //    //comp.PrintInfo();
            //    //Console.WriteLine(comp.IsEnoughRAM());
            //    //Console.WriteLine(comp);
            //    //Console.WriteLine("----------------------");
            //}

            //// paprasta kompozicija
            //Car car = new Car("Kia");
            //car.Model = "Test";
            //car.Engine = new Engine();
            //car.Engine.Liters = 5;
            //car.Engine.Type = "Dysel";

            //// lengviau skaitomas budas
            //// bet geriau per konstruktoriu (tam jis ir yra)
            //Car car2 = new Car("Audi")
            //{
            //    Model = "Test",
            //    Engine = new Engine()
            //    {
            //        Liters = 5,
            //        Type = "Dysel"
            //    },
            //    Wheels = new List<Wheel>
            //    {
            //        new Wheel
            //        {
            //            Brand = "Michelin",
            //            Size = 19
            //        },
            //        new Wheel
            //        {
            //            Brand = "Michelin",
            //            Size = 19
            //        },
            //        new Wheel
            //        {
            //            Brand = "Hankook",
            //            Size = 19
            //        },
            //        new Wheel
            //        {
            //            Brand = "Hankook",
            //            Size = 19
            //        }
            //    }
            //};

            //// pakeicia pirmo rato dydi
            //car2.Wheels[0].Size = 20;

            ////foreach (var wheel in Wheels)
            ////{

            ////}

            //Laptop laptop = new Laptop("Asus", DateTime.Now, "Nvidia", "AMD", 16, false);
            #endregion

            // #1
            #region
            //Person person = new Person("Jonas", 99);
            //Console.WriteLine($"{person.Name} is {person.Age} years old");
            //Person person2 = new Person("Jonas", 99, 190.5);
            //Console.WriteLine($"{person2.Name} is {person2.Age} years old and {person2.Height}cm tall");
            #endregion

            // #2
            #region
            //School school = new School("Licejus", "Vilnius", 550);
            //Console.WriteLine($"Mokykla: {school.Name}, miestas: {school.City}, mokiniu sk.: {school.NumberOfStudents}");
            #endregion

            // #3
            #region
            //Book book = new Book("Computer Systems: A Programmer's Perspective", "Randal E. Bryant, David R. O'Hallaron", 2015, "USA");
            //Console.WriteLine($"{book.Title}\n{book.AuthorName}\n{book.PublicationYear}\n{book.CountryOfPublication}\n");
            //Book book2 = new Book("Structure and Interpretation of Computer Programs", "Harold Abelson, Gerald J. Sussman, Julie Sussman", 1984, "USA");
            //Console.WriteLine($"{book2.Title}\n{book2.AuthorName}\n{book2.PublicationYear}\n{book2.CountryOfPublication}\n");
            //var books = new List<Book>
            //{
            //    book,
            //    book2
            //};

            //var filteredBooks = FilterByAuthorName(books, "Randal E. Bryant, David R. O'Hallaron");
            //foreach (var item in filteredBooks)
            //{
            //    Console.WriteLine(item.Title);
            //}
            #endregion

            // #4
            #region
            //var productsNames = new List<string>
            //{
            //    "Juoda duona",
            //    "Batonas",
            //    "Sviestas",
            //};
            //var productsNames2 = new List<string>
            //{
            //    "Sviestas",
            //    "Pienas",
            //    "Jogurtas"
            //};
            //Store store1 = new Store(2021, productsNames, "Iki");
            //Store store2 = new Store(2020, productsNames2, "Norfa");
            //Store store3 = new Store(2015, productsNames, "Rimi");

            //var stores = new List<Store>
            //{
            //    store1,
            //    store2,
            //    store3
            //};

            //foreach (var store in stores)
            //{
            //    foreach (var productName in store.ProductsNames)
            //    {
            //        Console.WriteLine($"{store.Name} {store.OpeningYear} - {productName}");
            //    }
            //    Console.WriteLine("--------------------------");
            //}
            #endregion

            // #5
            #region
            //Dog dog = new Dog("Roksis");
            //Cat cat = new Cat("Miauksis");
            //Cat cat2 = new Cat("Miauksis2");
            //Cat cat3 = new Cat("Miauksis3");
            //Hamster hamster = new Hamster("Kriuksis");
            //Hamster hamster2 = new Hamster("Kriuksis2");

            //var dogs = new List<Dog> { dog };
            //var cats = new List<Cat> { cat, cat2, cat3 };
            //var hamsters = new List<Hamster> { hamster, hamster2 };

            //var animalNames = GetAnimalNames(dog, cat, hamster);
            ////foreach (var name in animalNames)
            ////{
            ////    Console.WriteLine(name);
            ////}

            //var animalsAndQuantityOfSpecies = GetQuantityOfSpecies(dogs, cats, hamsters);
            //foreach (var animal in animalsAndQuantityOfSpecies)
            //{
            //    Console.Write($"{animal.Key} {animal.Value} ");
            //}
            //Console.WriteLine();
            #endregion

            // #6
            #region
            //Square square = new Square(3);
            //Console.WriteLine(GetSquareArea(square));
            //Console.WriteLine(GetSquarePerimeter(square));
            //Console.WriteLine("------------------------");

            //Triangle triangle = new Triangle(3.5, 6.5, 3.1);
            //Console.WriteLine(GetTriangleArea(triangle));
            //Console.WriteLine(GetTrianglePerimeter(triangle));
            //Console.WriteLine("------------------------");

            //Circle circle = new Circle(5);
            //Console.WriteLine(GetCircleArea(circle));
            //Console.WriteLine(GetCirclePerimeter(circle));
            //Console.WriteLine("------------------------");

            #endregion

            // #7
            #region
            //Car car = new Car();
            //car.StartEngine();
            //IsEngineON(car);
            #endregion

            // #8
            #region
            //Person2 person2 = new Person2("Jonas", 30, "Joniskis", "Joniskio");
            //Console.WriteLine(person2.Name);
            //Console.WriteLine(person2.Age);
            //Console.WriteLine(person2.Address.City);
            //Console.WriteLine(person2.Address.Street);
            #endregion

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

        // #5
        #region
        public static List<string> GetAnimalNames(Dog dog, Cat cat, Hamster hamster)
        {
            var names = new List<string>();
            names.Add(dog.Name);
            names.Add(cat.Name);
            names.Add(hamster.Name);
            return names;
        }

        public static Dictionary<string, int> GetQuantityOfSpecies(List<Dog> dogs, List<Cat> cats, List<Hamster> hamsters)
        {
            var numberOfSpecies = new Dictionary<string, int>();
            numberOfSpecies.Add("Dog", dogs.Count());
            numberOfSpecies.Add("Cat", cats.Count());
            numberOfSpecies.Add("Hamster", hamsters.Count());
            return numberOfSpecies;
        }
        #endregion

        // #6
        #region
        public static double GetSquareArea(Square square)
        {
            return square.Length * square.Length;
        }

        public static double GetSquarePerimeter(Square square)
        {
            return 4 * square.Length;
        }

        public static double GetTriangleArea(Triangle triangle)
        {
            double s = (triangle.SideA + triangle.SideB + triangle.SideC) / 2;
            return Math.Sqrt(s * (s - triangle.SideA) * (s - triangle.SideB) * (s - triangle.SideC));
        }

        public static double GetTrianglePerimeter(Triangle triangle)
        {
            return triangle.SideA + triangle.SideB + triangle.SideC;
        }

        public static double GetCircleArea(Circle circle)
        {
            return Math.PI * (circle.Radius * circle.Radius);
        }

        public static double GetCirclePerimeter(Circle circle)
        {
            return 2 * Math.PI * circle.Radius;
        }
        #endregion

        // #7
        public static void IsEngineON(Car car)
        {
            if (car.Engine.IsOn)
            {
                Console.WriteLine("Engine is on");
            }
            else
            {
                Console.WriteLine("Engine is off");
            }
        }
    }
}
