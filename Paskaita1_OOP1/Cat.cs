namespace Paskaita1_OOP1
{
    // #5
    internal class Cat
    {
        public Cat()
        {

        }

        public Cat(string name, int age)
        {
            Name = name;
            QuantityOfSpecies = age;
        }

        public string Name { get; set; }
        public int QuantityOfSpecies { get; set; }
    }
}
