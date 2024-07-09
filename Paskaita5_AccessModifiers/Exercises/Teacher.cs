namespace Paskaita5_AccessModifiers.Exercises
{
    public class Teacher : Person
    {
        public Teacher(string name, int age, string subject) : base(name, age)
        {
            Subject = subject;
            Name = name;
            Age = age;
        }

        private string Subject { get; set; }

        public string GetSubject()
        {
            return Subject;
        }
    }
}
