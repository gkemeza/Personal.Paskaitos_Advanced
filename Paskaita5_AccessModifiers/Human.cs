namespace Paskaita5_AccessModifiers
{
    public class Human
    {
        public Human()
        {
            Public = 0;
            Private = 0;
            Protected = 0;
            Internal = 0;
            ProtectedInternal = 0;
            PrivateProtected = 0;
        }

        public int Public { get; set; }
        private int Private { get; set; }
        protected int Protected { get; set; }
        internal int Internal { get; set; }
        protected internal int ProtectedInternal { get; set; }
        private protected int PrivateProtected { get; set; }
    }
}
