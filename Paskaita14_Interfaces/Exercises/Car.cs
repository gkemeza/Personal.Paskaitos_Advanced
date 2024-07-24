namespace Paskaita14_Interfaces.Exercises
{
    internal abstract class Car : IVehicle
    {
        public Car(string model, int? fuel)
        {
            Model = model;
            Fuel = fuel;
        }

        public string Model { get; set; }
        public int? Fuel { get; set; }

        public void Drive()
        {
            if (Fuel > 0)
            {
                Console.WriteLine($"{Model} has started driving!");
            }
            else
            {
                Console.WriteLine("Not enough fuel to drive!");
            }
        }

        public void Refuel(int litres)
        {
            if (litres >= 0)
            {
                Console.WriteLine($"Before refuel: {Fuel} L");
                Console.WriteLine($"Refueling {litres} L ...");
                Console.WriteLine($"After refuel: {Fuel += litres} L");
            }
            else
            {
                throw new ArgumentOutOfRangeException("can't refuel negative number of litres");
            }
        }
    }
}
