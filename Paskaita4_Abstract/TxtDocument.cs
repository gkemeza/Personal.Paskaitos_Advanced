namespace Paskaita4_Abstract
{
    public class TxtDocument : Document
    {
        public TxtDocument(string filePath, string title) : base(filePath, title)
        {

        }

        public override string Read()
        {
            Console.WriteLine($"Skaitau Txt: \"{Title}\"");
            return "Skaitau Txt";
        }

        public override void Write(string content)
        {
            Console.WriteLine($"Irasom i Txt: {content}");
        }
    }
}
