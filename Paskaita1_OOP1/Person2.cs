namespace Paskaita1_OOP1
{
    internal class Person2
    {
        public Person2(string name, int age, string city, string street)
        {
            Name = name;
            Age = age;
            Address = new Address(city, street);
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; }
    }
}
