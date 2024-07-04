namespace Paskaita4_Abstract.Exercises
{
    internal abstract class Human
    {
        protected Human(List<Vehicle> vehicles)
        {
            if (vehicles != null)
            {
                // AddRange, Add, and Clear are all methods of the List<Vehicle> class.
                // They modify the content of the list that Vehicles refers to, not the Vehicles property itself.
                Vehicles.AddRange(vehicles);  // This works with the existing list instance
            }
        }

        public List<Vehicle> Vehicles { get; } = new List<Vehicle>();

        public abstract void AddVehicle(Vehicle vehicle);
    }
}
