namespace Paskaita5_AccessModifiers.Exercises
{
    public class Student : Person
    {
        public Student(string name, int age, int studentId) : base(name, age)
        {
            StudentId = studentId;
            Name = name;
            Age = age;
        }

        private int StudentId { get; set; }

        public int GetStudentId()
        {
            return StudentId;
        }
    }
}
