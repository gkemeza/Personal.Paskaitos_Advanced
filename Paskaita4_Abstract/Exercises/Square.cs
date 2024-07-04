namespace Paskaita4_Abstract.Exercises
{
    internal class Square : GeometricShape
    {
        public Square(double length)
        {
            Length = length;
        }

        public double Length { get; set; }

        public override double GetArea()
        {
            return Length * Length;
        }

        public override double GetPerimeter()
        {
            return 4 * Length;
        }
    }
}
