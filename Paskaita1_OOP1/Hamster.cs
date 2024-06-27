namespace Paskaita1_OOP1
{
    // #5
    internal class Hamster
    {
        public Hamster()
        {

        }

        public Hamster(string name, int age)
        {
            Name = name;
            QuantityOfSpecies = age;
        }

        public string Name { get; set; }
        public int QuantityOfSpecies { get; set; }
    }
}
