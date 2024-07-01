namespace Paskaita1_OOP1
{
    //Paprasta kompozicija
    internal class Car
    {
        public Car()
        {
            Engine = new Engine();
        }

        public Car(bool isOn) : this()
        {
            Engine.IsOn = isOn;
        }

        public string Name { get; set; }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public List<Wheel> Wheels { get; set; }

        public void StartEngine()
        {
            Engine.IsOn = true;
        }
    }
}
