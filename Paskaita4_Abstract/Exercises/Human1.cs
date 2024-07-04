
namespace Paskaita4_Abstract.Exercises
{
    internal class Human1 : Human
    {
        public Human1(List<Vehicle> vehicles) : base(vehicles)
        {
        }

        public override void AddVehicle(Vehicle vehicle)
        {
            Vehicles.Add(vehicle);
        }
    }
}
