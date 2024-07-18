namespace Paskaita9_Generics
{
    public class FourSideGeometricFigure
    {
        public FourSideGeometricFigure(string name, double @base, double height)
        {
            Name = name;
            Base = @base;
            Height = height;
        }

        public string Name { get; set; }
        public double Base { get; set; }
        public double Height { get; set; }

        public double GetArea()
        {
            return Base * Height;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Base: {Base}, Height: {Height}";
        }
    }
}
