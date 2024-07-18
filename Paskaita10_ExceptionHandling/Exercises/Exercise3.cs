namespace Paskaita10_ExceptionHandling.Exercises
{
    internal class Exercise3
    {
        public static void FixedCode()
        {
            try
            {
                int[] arr = { 19, 0, 7, 52 };

                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i] / arr[i + 1]);
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"DivideByZeroException: {ex.Message}");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"IndexOutOfRangeException: {ex.Message}");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"OverflowException: {ex.Message}");
            }
        }
    }
}
