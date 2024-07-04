namespace Paskaita4_Abstract
{
    internal class WordDocument : Document
    {
        public WordDocument(string filePath, string title) : base(filePath, title)
        {

        }

        public override string Read()
        {
            Console.WriteLine($"Skaitau Word: \"{Title}\"");
            return "Skaitau Word";
        }

        public override void Write(string content)
        {
            Console.WriteLine($"Irasom i Word: {content}");
        }
    }
}
