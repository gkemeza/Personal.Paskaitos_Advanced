namespace Paskaita2_MethodsInClasses
{
    internal class Circle
    {
        public Circle(decimal radius)
        {
            Radius = radius;
        }

        public decimal Radius { get; set; }

        public decimal GetArea()
        {
            return (decimal)Math.PI * (Radius * Radius);
        }

        public decimal GetPerimeter()
        {
            return 2 * (decimal)Math.PI * Radius;
        }
    }
}
