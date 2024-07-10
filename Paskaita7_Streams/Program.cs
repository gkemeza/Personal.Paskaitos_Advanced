namespace Paskaita7_Streams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var smalsumas = new Smalsumas();
            smalsumas.OptimizacijosUzdavinys("data.txt", 5_000);
            Console.WriteLine("---------------Big Data---------------");
            // destytojas turejo 700_000 eiluciu teskta i bigData.txt isidejes 
            smalsumas.OptimizacijosUzdavinys("bigData.txt", 5_000);
        }
    }
}
