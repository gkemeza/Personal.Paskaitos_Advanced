namespace Paskaita9_Generics
{
    internal class Type<T1, T2>
    {
        public void GetType(T1 input)
        {
            Console.WriteLine(input.GetType());
        }
    }
}
