namespace Paskaita10_ExceptionHandling.Exercises
{
    internal class Exercise2
    {
        public static void FixedCode()
        {
            try
            {
                int[] arr = { 1, 2, 3, 4, 5 };

                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }

                Console.WriteLine(arr[7]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"IndexOutOfRangeException: {ex.Message}");
            }
        }
    }
}
