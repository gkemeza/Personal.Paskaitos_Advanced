namespace Paskaita2_MethodsInClasses
{
    internal class Numbers
    {
        public Numbers()
        {
            Integers = new List<int>();
        }

        public List<int> Integers { get; set; }

        public void AddNumber(int number)
        {
            Integers.Add(number);
        }

        public void PrintNumbers()
        {
            foreach (var number in Integers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
