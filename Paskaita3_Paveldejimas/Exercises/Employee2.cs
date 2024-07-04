namespace Paskaita3_Paveldejimas.Exercises
{
    internal class Employee2
    {
        public virtual string Greeting()
        {
            return "Greetings from employee!";
        }
    }

    internal class Manager2 : Employee2
    {
        public override string Greeting()
        {
            return "Greetings from manager!";
        }
    }
}
