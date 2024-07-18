namespace Paskaita10_ExceptionHandling.Exercises
{
    internal class Exercise1
    {
        // public static double ToDouble(string? value);
        // FormatException
        // OverflowException

        public static void TestToDouble()
        {
            var formatEx = "t";
            var overflowEx = "-1.7976931348623157E+400";

            try
            {
                double result1 = Convert.ToDouble(formatEx);
                double result2 = Convert.ToDouble(overflowEx);

                Console.WriteLine(result2);
                if (double.IsInfinity(result2))
                {
                    Console.WriteLine("The value is infinity");
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"FormatException: {ex.Message}");
            }
            // returns Double.PositiveInfinity instead of throwing an OverflowException.
            catch (OverflowException ex)
            {
                Console.WriteLine($"OverflowException: {ex.Message}");
            }
        }
    }
}
