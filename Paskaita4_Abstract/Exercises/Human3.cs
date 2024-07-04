
namespace Paskaita4_Abstract.Exercises
{
    internal class Human3 : Human
    {
        public Human3(List<Vehicle> vehicles) : base(vehicles)
        {
        }

        public override void AddVehicle(Vehicle vehicle)
        {
            Vehicles.Add(vehicle);
        }
    }
}
