namespace Paskaita4_Abstract
{
    public class PdfDocument : Document
    {
        public bool IsSigned { get; set; }

        public PdfDocument(string filePath, string title, bool isSigned) : base(filePath, title)
        {
            IsSigned = isSigned;
        }

        public void Sign()
        {
            throw new NotImplementedException();
        }

        public override string Read()
        {
            Console.WriteLine($"Skaitau Pdf: \"{Title}\"");
            return "Skaitau Pdf";
        }

        public override void Write(string content)
        {
            Console.WriteLine($"Irasom i Pdf: {content}");
        }
    }
}
