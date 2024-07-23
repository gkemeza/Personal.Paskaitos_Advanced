namespace Paskaita13_LINQ
{
    internal class Exercises
    {
        public static IEnumerable<string> SortWhereLengthIsMoreThan5(IEnumerable<string> collection)
        {
            return collection.Where(s => s.Length > 5);
        }
    }
}
