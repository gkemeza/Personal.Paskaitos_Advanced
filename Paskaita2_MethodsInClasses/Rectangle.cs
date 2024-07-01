namespace Paskaita2_MethodsInClasses
{
    internal class Rectangle
    {
        public Rectangle(decimal height, decimal width)
        {
            Height = height;
            Width = width;
        }

        public decimal Height { get; set; }
        public decimal Width { get; set; }

        public decimal GetArea()
        {
            return Height * Width;
        }

        public decimal GetPerimeter()
        {
            return 2 * (Height + Width);
        }
    }
}
