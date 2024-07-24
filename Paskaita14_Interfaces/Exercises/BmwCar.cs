namespace Paskaita14_Interfaces.Exercises
{
    internal class BmwCar : Car
    {
        public BmwCar(bool isXDrive, string model, int fuel) : base(model, fuel)
        {
            IsXDrive = isXDrive;
        }

        public bool IsXDrive { get; set; }
    }
}
