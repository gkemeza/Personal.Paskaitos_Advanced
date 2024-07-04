namespace Paskaita4_Abstract
{
    public abstract class Document
    {
        public Document(string filePath, string title)
        {
            FilePath = filePath;
            Title = title;
        }

        public string FilePath { get; set; }
        public string Title { get; set; }

        public void SetTitle(string title)
        {
            Title = title;
        }

        public abstract string Read();

        public abstract void Write(string content);
    }
}
