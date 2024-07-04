namespace Paskaita4_Abstract.Exercises
{
    internal class Bus : Vehicle
    {
        public Bus(int wheels, string color, DateTime yearManufactured, int capacity, bool hasWiFi) : base(wheels, color, yearManufactured)
        {
            Capacity = capacity;
            HasWiFi = hasWiFi;
        }

        public int Capacity { get; set; }
        public bool HasWiFi { get; set; }
    }
}
