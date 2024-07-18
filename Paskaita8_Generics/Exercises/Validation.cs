namespace Paskaita8_Generics.Exercises
{
    internal static class Validation<T>
    {
        public static void Validate(T value)
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