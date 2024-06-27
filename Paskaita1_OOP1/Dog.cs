namespace Paskaita1_OOP1
{
    // #5
    internal class Dog
    {
        public Dog()
        {

        }

        public Dog(string name, int age)
        {
            Name = name;
            QuantityOfSpecies = age;
        }

        public string Name { get; set; }
        public int QuantityOfSpecies { get; set; }
    }
}
