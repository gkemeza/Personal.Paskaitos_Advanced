
namespace Paskaita4_Abstract.Exercises
{
    internal class Scooter : Vehicle
    {
        public Scooter(int wheels, string color, DateTime yearManufactured, int weight) : base(wheels, color, yearManufactured)
        {
            Weight = weight;
        }

        public int Weight { get; set; }

    }
}
