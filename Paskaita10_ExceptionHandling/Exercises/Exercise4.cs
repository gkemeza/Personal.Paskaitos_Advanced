using System.Security;

namespace Paskaita10_ExceptionHandling.Exercises
{
    internal class Exercise4
    {
        public static void FileRead()
        {
            string path0 = @"../../../TestFile.txt";
            string path1 = "invalid.txt";
            string path2 = null;
            string path3 = " ";
            //File.WriteAllText(path0, "1 2 3");

            try
            {
                File.ReadAllText(path1);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"FileNotFoundException: {ex.Message}");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"ArgumentNullException: {ex.Message}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"ArgumentException: {ex.Message}");
            }
            catch (PathTooLongException ex)
            {
                Console.WriteLine($"PathTooLongException: {ex.Message}");
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine($"DirectoryNotFoundException: {ex.Message}");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"IOException: {ex.Message}");
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine($"UnauthorizedAccessException: {ex.Message}");
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine($"NotSupportedException: {ex.Message}");
            }
            catch (SecurityException ex)
            {
                Console.WriteLine($"NotSupportedException: {ex.Message}");
            }
        }
    }
}
