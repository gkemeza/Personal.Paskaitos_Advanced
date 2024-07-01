namespace Paskaita2_MethodsInClasses
{
    internal class Movie
    {
        public Movie(string title, string genre, double rating)
        {
            Title = title;
            Genre = genre;
            Rating = rating;
        }

        public string Title { get; set; }
        public string Genre { get; set; }
        public double Rating { get; set; }

        public bool CanIWatchIt()
        {
            if (Rating > 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
