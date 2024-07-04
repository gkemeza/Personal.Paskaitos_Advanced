namespace Paskaita3_Paveldejimas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region ***** Terminija *****
            /*
             - Inheritance (Paveldėjimas): Procesas, kuriuo viena klasė perima kitos klasės atributus ir operacijas.
             - Base Class (Bazinė klasė): Klasė, iš kurios paveldima. Taip pat žinoma kaip superclass, arba tėvinė klasė.
             - Derived Class (Paveldėta klasė): Klasė, kuri paveldi iš bazinės klasės. Taip pat žinoma kaip subclass arba child class.
             - Method Overriding (Metodų parrašymas): Paveldėtoje klasėje perrašytas bazinės klasės metodas, naudojant override raktinį žodį.
             - Method Hiding (Metodų slėpimas): Kai paveldėtoje klasėje sukuriamas metodas su tokiu pačiu pavadinimu kaip ir bazinėje klasėje, naudojant new raktinį žodį. Šis metodas slepia bazinės klasės metodą.
             - Virtual Method (Virtualus metodas): Bazinės klasės metodas, pažymėtas virtual raktiniu žodžiu, kuris gali būti perrašytas paveldėtoje klasėje.
             - Calling Base Class Constructors (Bazinių klasių konstruktorių kvietimas): Procesas, kuriuo paveldėtos klasės konstruktorius kviečia bazinės klasės konstruktorių.
             */
            #endregion

            #region ***** Skaidriu pavyzdziai *****
            // Polygon
            //var square = new Square();
            //Console.WriteLine($"NumberOfAngles: {0}", square.NumberOfAngles);
            //Console.WriteLine($"Size: {0}", square.Size);

            //var polygon = new Polygon();
            //Console.WriteLine($"NumberOfAngles: {0}", polygon.NumberOfAngles);
            //// size nepasiekiama, nes priklauso vaikui

            // Entity
            //var employee = new Employee();
            //var human = new Human();
            //var entity = new Entity();
            #endregion

            #region ***** #1 *****

            //var car = new Exercises.Car(40);
            //Console.WriteLine($"Car speed: {car.Speed}");

            //var bike = new Exercises.Bike(20);
            //bike.Speed = 25;
            //Console.WriteLine($"Bike speed: {bike.Speed}");

            #endregion

            #region ***** #2 *****

            //var employees = new List<Exercises.Employee>();

            //var employee1 = new Exercises.Employee("Benas", 1200);
            //employees.Add(employee1);
            //var employee2 = new Exercises.Employee("Lukas", 1000);
            //employees.Add(employee2);

            //var manager1 = new Exercises.Manager("Jonas", 1500, employees);

            //Console.WriteLine($"Manager Name: {manager1.Name}");
            //Console.WriteLine($"Manager Salary: {manager1.Salary}");
            //Console.WriteLine($"Manager Employess count: {manager1.Employees.Count}");

            #endregion

            #region ***** #3 *****

            //var transport = new Exercises.Transport();
            //Console.WriteLine(transport.MeasureSpeed());

            //var car = new Exercises.Car2();
            //Console.WriteLine(car.MeasureSpeed());

            #endregion

            #region ***** #4 *****

            //var employee = new Exercises.Employee2();
            //Console.WriteLine(employee.Greeting());

            //var manager = new Exercises.Manager2();
            //Console.WriteLine(manager.Greeting());

            #endregion

            #region ***** #5 *****

            //var shape = new Exercises.Shape();
            //var circle = new Exercises.Circle();
            //var rectangle = new Exercises.Rectangle();
            //Console.WriteLine(shape.Draw());
            //Console.WriteLine(circle.Draw());
            //Console.WriteLine(rectangle.Draw());

            #endregion

            #region ***** #6 TransportRentalSystem (to-do) *****



            #endregion

        }
    }
}