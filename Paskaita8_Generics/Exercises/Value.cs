namespace Paskaita8_Generics.Exercises
{
    internal class Value
    {
        public void ShowValues<T1, T2>(T1 value1, T2 value2)
        {
            Console.WriteLine(value1);
            Console.WriteLine(value2);
        }
    }
}
