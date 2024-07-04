namespace Paskaita3_Paveldejimas.Exercises
{
    public class Employee
    {
        public Employee(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }

        public string Name { get; set; }
        public int Salary { get; set; }
    }

    public class Manager : Employee
    {
        public Manager(string name, int salary, List<Employee> employess) : base(name, salary)
        {
            Employees = employess;
        }

        public List<Employee> Employees { get; set; } = new List<Employee>();
    }
}
