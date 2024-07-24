namespace Paskaita14_Interfaces.Exercises
{
    internal class AudiCar : Car
    {
        public AudiCar(bool isQuattro, string model, int? fuel) : base(model, fuel)
        {
            IsQuattro = isQuattro;
        }

        public bool IsQuattro { get; set; }

        public override string ToString()
        {
            return $"Model: {Model}, Fuel: {Fuel}L";
        }
    }
}
