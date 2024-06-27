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
            //Dog dog = new Dog("Roksis", 12);
            //Cat cat = new Cat("Miauksis", 5);
            //Hamster hamster1 = new Hamster("Kriuksis", 9);

            //var dogs = new List<Dog> { dog };
            //var cats = new List<Cat> { cat };
            //var hamsters = new List<Hamster> { hamster1 };

            //var animalNames = GetAnimalNames(dogs, cats, hamsters);
            //foreach (var name in animalNames)
            //{
            //    Console.WriteLine(name);
            //}

            //var quantityOfSpecies = GetQuantityOfSpecies(dogs, cats, hamsters);
            //foreach (var species in quantityOfSpecies)
            //{
            //    Console.Write($"{species} ");
            //}
            //Console.WriteLine();
            #endregion

            // #6
            #region
            Square square = new Square(3);
            Console.WriteLine(GetSquareArea(square));
            Console.WriteLine(GetSquarePerimeter(square));
            Console.WriteLine("------------------------");

            Triangle triangle = new Triangle(3.5, 6.5, 3.1);
            Console.WriteLine(GetTriangleArea(triangle));
            Console.WriteLine(GetTrianglePerimeter(triangle));
            Console.WriteLine("------------------------");

            Circle circle = new Circle(5);
            Console.WriteLine(GetCircleArea(circle));
            Console.WriteLine(GetCirclePerimeter(circle));
            Console.WriteLine("------------------------");

            #endregion

            // #7
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
        public static List<string> GetAnimalNames(List<Dog> dogs, List<Cat> cats, List<Hamster> hamsters)
        {
            var names = new List<string>();
            foreach (var dog in dogs)
            {
                names.Add(dog.Name);
            }
            foreach (var cat in cats)
            {
                names.Add(cat.Name);
            }
            foreach (var hamster in hamsters)
            {
                names.Add(hamster.Name);
            }
            return names;
        }

        // #5
        public static List<string> GetQuantityOfSpecies(List<Dog> dogs, List<Cat> cats, List<Hamster> hamsters)
        {
            var numberOfSpecies = new List<string>();
            foreach (var dog in dogs)
            {
                numberOfSpecies.Add($"{dog.GetType().Name} {dog.QuantityOfSpecies}");
            }
            foreach (var cat in cats)
            {
                numberOfSpecies.Add($"{cat.GetType().Name} {cat.QuantityOfSpecies}");
            }
            foreach (var hamster in hamsters)
            {
                numberOfSpecies.Add($"{hamster.GetType().Name} {hamster.QuantityOfSpecies}");
            }
            return numberOfSpecies;
        }

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
    }
}
