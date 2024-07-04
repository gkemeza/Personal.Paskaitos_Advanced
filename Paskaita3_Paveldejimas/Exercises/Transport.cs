namespace Paskaita3_Paveldejimas.Exercises
{
    public class Transport
    {
        public virtual string MeasureSpeed()
        {
            return "Standart speed measurement";
        }
    }

    public class Car2 : Transport
    {
        public override string MeasureSpeed()
        {
            return "Car speed measurement is 100 km/h";
        }
    }
}
