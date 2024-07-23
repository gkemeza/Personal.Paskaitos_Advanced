namespace Paskaita13_LINQ
{
    internal class Iphone
    {
        public Iphone(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
