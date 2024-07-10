namespace Paskaita8_Generics
{
    internal abstract class Vegetable
    {
        public int Id { get; set; }
        public string Color { get; set; }
    }

    internal class Tomato : Vegetable
    {
        public int Juiciness { get; set; }
    }

    internal class Potato : Vegetable
    {

    }

    internal class Carrot : Vegetable
    {
        public int Length { get; set; }
    }
}
