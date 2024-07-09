namespace Paskaita6_Streams.Exercises
{
    public class Exercise1
    {
        public void PrintAllText(string filePath)
        {
            Console.WriteLine(Directory.GetCurrentDirectory());
            Console.WriteLine(File.ReadAllText(filePath));
        }
    }
}
