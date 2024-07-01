namespace Paskaita2_MethodsInClasses
{
    internal class Library
    {
        public Library()
        {
            Books = new List<Book>();
        }

        public List<Book> Books { get; set; }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            Books.Remove(book);
        }
    }
}
