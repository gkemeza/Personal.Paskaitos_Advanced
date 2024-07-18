namespace Paskaita11_ExtensionMethods
{
    internal static class MyExtensions
    {
        public static bool IsEmpty(this string str)
        {
            return string.IsNullOrWhiteSpace(str);
        }

        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }

        public static PersonDTO PersonToDto(this Person person)
        {
            if (person == null)
            {
                return null;
            }
            return new PersonDTO
            {
                Name = person.Name,
                Age = person.Age
            };
        }

        public static void PrintAllItems<T>(this List<T> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
