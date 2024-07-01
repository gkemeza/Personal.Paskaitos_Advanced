namespace Paskaita2_MethodsInClasses
{
    internal class Playlist
    {
        public Playlist()
        {
            Songs = new List<Song>();
        }

        public List<Song> Songs { get; set; }

        public void AddSong(Song song)
        {
            Songs.Add(song);
        }

        public void RemoveSong(Song song)
        {
            Songs.Remove(song);
        }
    }
}
