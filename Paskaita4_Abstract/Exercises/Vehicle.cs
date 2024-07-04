namespace Paskaita4_Abstract.Exercises
{
    internal class Vehicle
    {
        public Vehicle(int wheels, string color, DateTime yearManufactured)
        {
            Wheels = wheels;
            Color = color;
            YearManufactured = yearManufactured;
        }

        public int Wheels { get; set; }
        public string Color { get; set; }
        public DateTime YearManufactured { get; set; }
    }
}
