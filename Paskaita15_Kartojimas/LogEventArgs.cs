namespace Paskaita15_Kartojimas
{
    public class LogEventArgs : EventArgs
    {
        public string Message { get; set; }

        public LogEventArgs(string message)
        {
            Message = message;
        }
    }
}
