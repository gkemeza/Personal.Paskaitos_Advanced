namespace Paskaita5_AccessModifiers.Exercises
{
    public class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        private string name;
        private int age;

        protected string Name
        {
            get { return name; }
            set { name = value; }
        }

        protected int Age
        {
            get { return age; }
            set { age = value; }
        }

        protected void PrintInfo()
        {
            Console.WriteLine($"Vardas: {Name}");
            Console.WriteLine($"Amzius: {Age}");
        }
    }
}
