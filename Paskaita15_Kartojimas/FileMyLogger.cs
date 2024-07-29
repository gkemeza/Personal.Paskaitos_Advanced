namespace Paskaita15_Kartojimas
{
    public class FileMyLogger : IMyLogger
    {
        private readonly string _filePath;

        public FileMyLogger(string filePath)
        {
            _filePath = filePath;
        }

        public void Log(string message)
        {
            try
            {
                File.AppendAllText(_filePath, message + Environment.NewLine);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
