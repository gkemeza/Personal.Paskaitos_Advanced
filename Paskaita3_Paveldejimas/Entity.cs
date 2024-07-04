namespace Paskaita3_Paveldejimas
{
    public class Entity
    {
        public int Id { get; set; }
    }

    public class Human : Entity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
    }

    public class Employee : Human
    {
        public double Salary { get; set; }
        public DateTime EmploymentDate { get; set; }
    }
}
