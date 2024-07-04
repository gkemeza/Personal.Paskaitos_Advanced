namespace Paskaita3_Paveldejimas.Exercises
{
    public class Vehicle
    {
        public Vehicle(int speed)
        {
            Speed = speed;
        }

        public int Speed { get; set; }
    }

    public class Car : Vehicle
    {
        // Calling Base Class Constructors
        public Car(int speed) : base(speed)
        {
        }
    }

    public class Bike : Vehicle
    {
        public Bike(int speed) : base(speed)
        {
        }
    }
}
