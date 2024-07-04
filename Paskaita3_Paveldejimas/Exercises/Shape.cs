namespace Paskaita3_Paveldejimas.Exercises
{
    internal class Shape
    {
        public virtual string Draw()
        {
            return "Draw a shape";
        }
    }

    internal class Circle : Shape
    {
        public override string Draw()
        {
            return "Draw a circle";
        }
    }

    internal class Rectangle : Shape
    {
        public override string Draw()
        {
            return "Draw a rectangle";
        }
    }
}
