namespace Paskaita1_OOP1
{
    //Paprasta kompozicija
    internal class Car
    {
        public Car(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public List<Wheel> Wheels { get; set; }
    }
}
