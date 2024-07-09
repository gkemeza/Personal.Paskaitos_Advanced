namespace Paskaita5_AccessModifiers.Exercises
{
    internal class Developer : Employee
    {
        public sealed override decimal GetSalary()
        {
            return 800;
        }
    }
}
