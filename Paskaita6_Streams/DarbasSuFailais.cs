namespace Paskaita6_Streams
{
    public class DarbasSuFailais
    {


        public string ReadAllText(string filePath)
        {
            return File.ReadAllText(filePath);
        }

        public void WriteAllText(string filePath, string text)
        {
            File.WriteAllText(filePath, text);
        }

        public string[] ReadAllLines(string path)
        {
            return File.ReadAllLines(path);
        }

        public void WriteAllLines(string filePath, string[] lines)
        {
            File.WriteAllLines(filePath, lines);
        }
    }
}
