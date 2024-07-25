namespace Paskaita15_Kartojimas
{
    public class BufferedFileLogger : IMyLogger
    {
        private readonly string _filePath;
        private readonly int _bufferSize;
        private readonly List<string> _messages = new List<string>();

        public BufferedFileLogger(string filePath, int bufferSize)
        {
            _filePath = filePath;
            _bufferSize = bufferSize;
        }

        public void Log(string message)
        {
            _messages.Add(message);

            if (_messages.Count >= _bufferSize)
            {
                Flush();
            }
        }

        private void Flush()
        {
            var fileLogger = new FileMyLogger(_filePath);
            _messages.ForEach(fileLogger.Log);
            _messages.Clear();
        }
    }
}
