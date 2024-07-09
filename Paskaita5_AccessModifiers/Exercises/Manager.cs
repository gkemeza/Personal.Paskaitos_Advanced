namespace Paskaita5_AccessModifiers.Exercises
{
    internal class Manager : Employee
    {
        public override sealed decimal GetSalary()
        {
            return 1200;
        }
    }

    internal class BestManager : Manager
    {
        // "cannot override inherited member because it is sealed"
        //public override sealed decimal GetSalary()
        //{
        //    return 1500;
        //}
    }
}
