namespace Paskaita8_Generics.Exercises
{
    internal static class Validation
    {
        public static void Validate<T>(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("Paduotas parametras yra null");
            }
            else
            {
                Console.WriteLine("Ne null");
            }
        }
    }
}