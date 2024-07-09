namespace Paskaita6_Streams.Exercises
{
    internal class Exercise2
    {
        public void WriteText()
        {
            Console.WriteLine(Directory.GetCurrentDirectory());
            // .. goes one level up
            var filePath = "..\\..\\..\\Exercises\\text2.txt";
            List<string> text = new List<string>()
        {
            "Mano", "batai, buvo", "labai labai dideli."
        };
            File.WriteAllLines(filePath, text);
        }

        // pabaigti
        public void ReadLines()
        {
            Console.WriteLine(File.ReadAllLines("Exercises\\text.txt"));
        }
    }
}
