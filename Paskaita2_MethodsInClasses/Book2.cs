namespace Paskaita2_MethodsInClasses
{
    internal class Book2
    {
        public Book2(string title, string author, int pages)
        {
            Title = title;
            Author = author;
            Pages = pages;
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }

        public double HowLongToFinish()
        {
            return Math.Round((double)Pages / 50);
        }
    }
}
