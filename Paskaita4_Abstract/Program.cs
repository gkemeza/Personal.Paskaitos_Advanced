using Paskaita4_Abstract.Exercises;

namespace Paskaita4_Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ***** Paskaitos pavyzdys *****

            //TxtDocument txtDocument = new TxtDocument("testas.txt", "TestFile");
            //txtDocument.Write("irasom testFile...");

            //PdfDocument pdfDocument = new PdfDocument("saskaita.pdf", "Saskaita", true);
            //pdfDocument.Write("irasom saskaita...");

            //WordDocument wordDocument = new WordDocument("saskaita.docx", "Sutartis");
            //wordDocument.Write("irasom sutarti...");
            //wordDocument.SetTitle("Sutartis 2");
            //Console.WriteLine();

            //List<Document> documents = new List<Document>();
            //documents.Add(txtDocument);
            //documents.Add(pdfDocument);
            //documents.Add(wordDocument);

            //// TxtDocument objektas idetas i Document tipa (kaip saraso pvz.)
            //Document txtDocument2 = new TxtDocument("testas.txt", "TestFile");

            //foreach (var document in documents)
            //{
            //    var content = document.Read();
            //    // Kadangi List yra Document tipo - negalima pasiekti vaikiniu klasiu dalyku
            //    // var isSigned = document.IsSigned;
            //    // document.Sign();

            //    Console.WriteLine($"{document.Title}: \n {content}");
            //    Console.WriteLine();
            //}

            #endregion

            #region ***** #1 *****

            //Triangle triangle = new Triangle(2, 3, 3);
            //Console.WriteLine(triangle.GetArea());
            //Console.WriteLine(triangle.GetPerimeter());

            //Square square = new Square(6);
            //Console.WriteLine(square.GetArea());
            //Console.WriteLine(square.GetPerimeter());

            #endregion

            #region ***** #2 *****

            //Dog dog = new Dog();
            //dog.MakeNoise();

            //Cat cat = new Cat();
            //cat.MakeNoise();

            //interesting error
            //Console.WriteLine(cat.MakeNoise());

            #endregion

            #region ***** #3 *****

            //Triangle triangle = new Triangle(2, 3, 3);
            //Square square = new Square(6);

            //var shapes = new List<GeometricShape>();
            //shapes.Add(triangle);
            //shapes.Add(square);

            //foreach (var shape in shapes)
            //{
            //    Console.WriteLine($"Area: {shape.GetArea()}");
            //    Console.WriteLine($"Perimeter: {shape.GetPerimeter()}");
            //}

            #endregion            

            #region ***** #4 *****

            Bus bus = new Bus(10, "Blue", new DateTime(2018, 05, 19), 25, true);
            Truck truck = new Truck(10, "Blue", new DateTime(2015, 05, 19), 100);
            Vehicle scooter = new Scooter(10, "Blue", new DateTime(2022, 05, 19), 20);

            var vehicles = new List<Vehicle>();
            vehicles.Add(bus);
            vehicles.Add(truck);
            vehicles.Add(scooter);

            var vehicles2 = new List<Vehicle>();
            vehicles2.Add(bus);
            vehicles2.Add(truck);

            var human1 = new Human1(vehicles);
            Human human2 = new Human2(vehicles2);
            Human3 human3 = new Human3(vehicles);

            human1.AddVehicle(bus);
            human2.AddVehicle(truck);
            human3.AddVehicle(scooter);

            #endregion
        }
    }
}
