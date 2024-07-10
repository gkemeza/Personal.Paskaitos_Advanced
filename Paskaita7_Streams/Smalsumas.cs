using System.Diagnostics;

namespace Paskaita7_Streams
{
    internal class Smalsumas
    {
        public void OptimizacijosUzdavinys(string path, int samples)
        {
            var timer = new Stopwatch();
            Console.WriteLine("Tikriname File.ReadAllLines() efektyvuma");
            timer.Start();

            for (int i = 0; i < samples; i++)
            {
                var lines = File.ReadAllLines(path);
                foreach (var line in lines)
                {
                    // prasukam cikla, kad tikrai butu failo ...(19.13)
                }
            }
            timer.Stop();
            var readAllLinesTime = timer.ElapsedMilliseconds;
            Console.WriteLine($"File.ReadAllLines() uztruko: {readAllLinesTime}ms");

            Console.WriteLine("Tikriname File.ReadLines() efektyvuma");
            timer.Restart();

            for (int i = 0; i < samples; i++)
            {
                var lines = File.ReadLines(path);
                foreach (var line in lines)
                {
                    // prasukam cikla, kad tikrai butu failo ...(19.13)
                }
            }
            timer.Stop();
            var readLinesTime = timer.ElapsedMilliseconds;
            Console.WriteLine($"File.ReadLines() uztruko: {readLinesTime}ms");

            Console.WriteLine("Tikriname File.ReadLines() kartu su ToArray() efektyvuma");
            timer.Restart();

            for (int i = 0; i < samples; i++)
            {
                var lines = File.ReadLines(path).ToArray();
                foreach (var line in lines)
                {
                    // prasukam cikla, kad tikrai butu failo ...(19.13)
                }
            }
            timer.Stop();
            var readLinesToArrayTime = timer.ElapsedMilliseconds;
            Console.WriteLine($"File.ReadLines() kartu su ToArray() uztruko: {readLinesToArrayTime}ms");

            Console.WriteLine("Tikriname File.ReadLines(), o poto Split() efektyvuma");
            timer.Restart();

            for (int i = 0; i < samples; i++)
            {
                var lines = File.ReadAllText(path).Split('\n');
                foreach (var line in lines)
                {
                    // prasukam cikla, kad tikrai butu failo ...(19.13)
                }
            }
            timer.Stop();
            var readAllTextTime = timer.ElapsedMilliseconds;
            Console.WriteLine($"File.ReadAllText(), o poto Split() uztruko: {readAllTextTime}ms");
        }
    }
}
