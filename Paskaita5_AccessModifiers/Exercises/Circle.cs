namespace Paskaita5_AccessModifiers.Exercises
{
    internal class Circle : Shape
    {
        private decimal radius;

        public Circle(decimal radius)
        {
            Radius = radius;
        }

        public decimal Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public sealed override decimal CalculateArea()
        {
            return (decimal)Math.PI * (Radius * Radius);
        }
    }

    internal class BigCircle : Circle
    {
        public BigCircle(decimal radius) : base(radius)
        {
        }

        // "cannot override inherited member because it is sealed"
        //public override decimal CalculateArea()
        //{
        //    return 5;
        //}

    }
}
