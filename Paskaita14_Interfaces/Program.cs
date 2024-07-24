using Paskaita14_Interfaces.Exercises;

namespace Paskaita14_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ***** Theory *****

            //var shapes = new List<IShape>
            //{
            //   new Triangle(3, 4),
            //   new Square(5, 5)
            //};

            ////foreach (IShape shape in shapes)
            ////{
            ////    Console.WriteLine($"Perimeter: {shape.GetPerimeter()}");
            ////    Console.WriteLine($"Area: {shape.GetArea()}");
            ////}

            //shapes.ForEach(shape =>
            //    {
            //        Console.WriteLine($"Perimeter: {shape.GetPerimeter()}");
            //        Console.WriteLine($"Area: {shape.GetArea()}");
            //    });

            //Shop shop = new Shop(new Paypal());
            //shop.Buying(100);

            //var squares = new List<Square>()
            //{
            //    new Square(5, 5),
            //    new Square(3, 3),
            //    new Square(2, 2),
            //    new Square(6, 6),
            //    new Square(4, 4)
            //};

            //SquareComparer squareComparer = new SquareComparer();
            //squares.Sort(squareComparer);

            ////squares.ForEach(square =>
            ////    {
            ////        Console.WriteLine($"Area: {square.GetArea()}");
            ////    });

            //var shapes = new List<IShape>()
            //{
            //    new Square(3, 3),
            //    new Square(2, 2),
            //    new Square(5, 5),
            //    new Triangle(3, 4),
            //    new Triangle(6, 6),
            //    new Triangle(4, 4),
            //};

            //ShapesComparer shapesComparer = new ShapesComparer();
            //shapes.Sort(shapesComparer);

            //shapes.ForEach(shape =>
            //    {
            //        Console.WriteLine($"Area: {shape.GetArea()}");
            //    });

            #endregion

            #region ***** Exercises *****

            // #1-2
            //var bmw = new BmwCar(true, "Bmw", 0);
            //var audi = new AudiCar(false, "Audi", 5);

            //bmw.Drive();
            //bmw.Refuel(3);

            //Console.WriteLine();
            //audi.Drive();
            //audi.Refuel(1);

            // #3
            var audiCarList = new List<AudiCar>
            {
                new AudiCar(false, "Audi1", 5),
                new AudiCar(true, "Audi2", null),
                new AudiCar(true, "Audi3", 3),
                new AudiCar(false, "Audi4", 1),
                new AudiCar(false, "Audi5", null)
            };

            var audiCarComparer = new AudiCarComparer();
            audiCarList.Sort(audiCarComparer);

            audiCarList.ForEach(audi => Console.WriteLine($"{audi}"));

            #endregion
        }
    }
}
