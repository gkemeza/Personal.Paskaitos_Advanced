namespace Paskaita1_OOP1
{
    internal class Book
    {
        private string title1;
        public string Title
        {
            get { return title1; }
            set { title1 = value; }
        }
        public string AuthorName { get; set; }
        public int PublicationYear { get; set; }
        public string CountryOfPublication { get; set; }

        public Book(string title, string authorName, int publicationYear, string countryOfPublication)
        {
            Title = title;
            AuthorName = authorName;
            PublicationYear = publicationYear;
            CountryOfPublication = countryOfPublication;
        }
    }
}
