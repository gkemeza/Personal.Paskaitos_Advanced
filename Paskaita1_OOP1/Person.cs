namespace Paskaita1_OOP1
{
    // #1
    internal class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public Person(string name, int age, double height)
        {
            Name = name;
            Age = age;
            Height = height;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
    }
}
