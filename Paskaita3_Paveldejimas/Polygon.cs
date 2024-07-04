namespace Paskaita3_Paveldejimas
{
    public class Polygon
    {
        public Polygon()
        {
            NumberOfAngles = 0;
        }

        public Polygon(int numberOfAngles)
        {
            NumberOfAngles = numberOfAngles;
        }

        public int NumberOfAngles { get; set; }

        public virtual double GetPerimeter()
        {
            return 0;
        }
    }

    public class Square : Polygon
    {
        public Square()
        {
            NumberOfAngles = 4;
        }

        public Square(double size)
        {
            Size = size;
            NumberOfAngles = 4;
        }

        public double Size { get; set; }

        public override double GetPerimeter()
        {
            //base.GetPerimeter(); - jei reikia iskviesti base klases metoda
            return 4 * NumberOfAngles;
        }
    }
}
