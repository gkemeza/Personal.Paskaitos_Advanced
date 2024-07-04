
namespace Paskaita4_Abstract.Exercises
{
    internal class Human2 : Human
    {
        public Human2(List<Vehicle> vehicles) : base(vehicles)
        {
        }

        public override void AddVehicle(Vehicle vehicle)
        {
            Vehicles.Add(vehicle);
        }
    }
}
