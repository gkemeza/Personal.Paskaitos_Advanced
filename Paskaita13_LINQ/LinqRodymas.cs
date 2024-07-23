namespace Paskaita13_LINQ
{
    internal class LinqRodymas
    {
        //nurasyti teorija

        public void A_Main()
        {
            var kolekcijaSarasas = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var kolekcijaMasyvas = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var kolekcijaZodynas = new Dictionary<int, string>
            {
                {1, "vienas" },
                {2, "du" },
                {3, "trys" },
                {4, "keturi" },
                {5, "penki" }
            };

            // LINQ turi 2 budus kaip galima naudoti:
            // 1. Query syntax
            var querySyntax = from s in kolekcijaSarasas
                              where s > 5
                              select s;

            // 2. Method syntax (Extension method syntax)
            var methodSyntax = kolekcijaSarasas.Where(n => n > 5);

            // norime lyginiu skaiciu is kolekcijos kolekcijaMasyvas
            var lyginiai = kolekcijaMasyvas.Where(n => n % 2 == 0);

            var persons = new List<Person>
            {
                new Person{ FirstName = "Jonas", LastName = "Jonaitis", BirthDate = new DateTime(1990, 1, 1), Address = "Vilnius"},
                new Person{ FirstName = "Antanas", LastName = "Antanaitis", BirthDate = new DateTime(1994, 1, 1), Address = "Vilnius"},
                new Person{ FirstName = "Lukas", LastName = "Lukaitis", BirthDate = new DateTime(2000, 1, 1), Address = "Vilnius"}
            };

            var students = persons.Select(p => new Student
            {
                Name = p.FirstName + " " + p.LastName,
                Age = DateTime.Now.Year - p.BirthDate.Year
            }).Where(s => s.Age >= 30).OrderBy(s => s.Age);

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name} {student.Age}");
            }
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
    }
}
