namespace Paskaita15_Kartojimas
{
    public class ConsoleMyLogger : IMyLogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
