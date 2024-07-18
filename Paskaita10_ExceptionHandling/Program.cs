using Paskaita10_ExceptionHandling.Exercises;

namespace Paskaita10_ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ***** Theory *****

            //int mistakes = 0;
            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine($"You made {mistakes} mistakes (max 3)");
            //        int a = int.Parse(Console.ReadLine());
            //        int b = int.Parse(Console.ReadLine());

            //        double division = Divide(a, b);
            //        Console.WriteLine($"Answer: {division}");
            //    }
            //    catch (DivideByZeroException ex)
            //    {
            //        Console.WriteLine($"Error: Negalima dalinti is nulio");
            //    }
            //    catch (HasToBeLargerException ex)
            //    {
            //        Console.WriteLine($"Error: {ex.Message}");
            //        mistakes++;
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine($"Error: {ex.Message}");
            //    }
            //    finally
            //    {
            //        Console.WriteLine("Baigta");
            //    }
            //}

            #endregion

            #region ***** #1 *****

            //Exercise1.TestToDouble();

            #endregion

            #region ***** #2 *****

            //Exercise2.FixedCode();

            #endregion

            #region ***** #3 *****

            //Exercise3.FixedCode();

            #endregion

            #region ***** #4 *****

            //Exercise4.FileRead();

            #endregion
        }

        // padejus '///' auto atsiranda
        /// <summary>
        /// Divides <paramref name="a"/> from <paramref name="b"/>
        /// <code>a / b = result</code>
        /// </summary>
        /// <param name="a">Dividend</param>
        /// <param name="b">Divisor</param>
        /// <returns>An int value of the division result</returns>
        /// <exception cref="HasToBeLargerException"></exception>
        /// <exception cref="DivideByZeroException"></exception>
        public static int Divide(int a, int b)
        {
            if (a < b)
            {
                throw new HasToBeLargerException("A has to be larger than B");
            }
            return a / b;
        }
    }
}
