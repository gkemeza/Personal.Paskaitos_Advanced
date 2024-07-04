namespace Paskaita4_Abstract.Exercises
{
    internal class Truck : Vehicle
    {
        public Truck(int wheels, string color, DateTime yearManufactured, int cargoCapacity) : base(wheels, color, yearManufactured)
        {
            CargoCapacity = cargoCapacity;
        }

        public int CargoCapacity { get; set; }

    }
}
