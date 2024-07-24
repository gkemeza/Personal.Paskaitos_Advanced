namespace Paskaita14_Interfaces
{
    internal class Square : IShape
    {
        public Square(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Width { get; set; }
        public double Height { get; set; }

        public double GetArea()
        {
            return Width * Width;
        }

        public double GetPerimeter()
        {
            return 4 * Width;
        }
    }
}
