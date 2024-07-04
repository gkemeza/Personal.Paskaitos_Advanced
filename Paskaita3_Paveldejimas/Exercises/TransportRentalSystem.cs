namespace Paskaita3_Paveldejimas.Exercises
{
    // creative uzduotis
    // su ai paklausti ka reiketu ideti i sitas klases
    public class TransportRentalSystem
    {

    }

    public class Client
    {
        public string Name { get; set; }
        public int MyProperty { get; set; }
        public double BasePrice { get; set; }

        public virtual double CalculateTotal()
        {
            return BasePrice;
        }
    }

    public class VipClient : Client
    {
        public override double CalculateTotal()
        {
            throw new NotImplementedException();
        }
    }
    public class StandartClient : Client
    {
        public override double CalculateTotal()
        {
            throw new NotImplementedException();
        }
    }
    public class EcoClient : Client
    {
        public override double CalculateTotal()
        {
            throw new NotImplementedException();
        }
    }

    public class Vehicle2
    {
        public Vehicle2(int speed, int capacity, int fuelEfficiency)
        {
            Speed = speed;
            Capacity = capacity;
            FuelEfficiency = fuelEfficiency;
        }

        public int Speed { get; set; }
        public int Capacity { get; set; }
        public int FuelEfficiency { get; set; }

        public virtual void PrintMaxSpeed()
        {
            Console.WriteLine($"Max speed: {Speed} km/h");
        }

        public int GetCapacity()
        {
            return Capacity;
        }

        public int GetFuelEfficiency()
        {
            return FuelEfficiency;
        }

        public virtual string Drive()
        {
            return "You are driving a vehicle";
        }
    }

    public class Payment
    {
        public string Type { get; set; }
    }
}
