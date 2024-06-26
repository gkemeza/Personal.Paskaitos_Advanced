namespace Paskaita1_OOP1
{
    // #2
    internal class School
    {
        public string Name { get; set; }
        public string City { get; set; }
        public int NumberOfStudents { get; set; }

        public School(string name, string city, int numberOfStudents)
        {
            Name = name;
            City = city;
            NumberOfStudents = numberOfStudents;
        }
    }
}
