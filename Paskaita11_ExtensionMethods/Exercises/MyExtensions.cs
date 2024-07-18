namespace Paskaita11_ExtensionMethods.Exercises
{
    internal static class MyExtensions
    {
        public static bool IsPositive(this int number)
        {
            return number > 0;
        }

        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }

        public static bool IsBigger(this int number, int number2)
        {
            return number > number2;
        }

        public static bool HasEmptySpaces(this string text)
        {
            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (char.IsWhiteSpace(text[i]))
            //    {
            //        return true;
            //    }
            //}
            //return false;
            return text.Contains(' ');
        }

        public static string GetEMail(this string fullName, int yearOfBirth, string domain)
        {
            return $"{fullName.ToLower()}{yearOfBirth}{domain.ToLower()}";
        }

        public static T FindAndReturnIfEqual<T>(this List<T> list, T obj)
        {
            foreach (var item in list)
            {
                if (EqualityComparer<T>.Default.Equals(item, obj))
                {
                    return item;
                }
            }
            return default(T);
        }

        public static List<T> EveryOtherWord<T>(this List<T> list)
        {
            // geriau add to new list?
            var newList = new List<T>(list);
            foreach (var item in list)
            {
                if (list.IndexOf(item) % 2 != 0)
                {
                    newList.Remove(item);
                }
            }
            return newList;
        }

        // ar galima extendint File klase? (ne, nes statine)
        // apejimas, pasibandyti
        public static List<string> GetEveryOtherLine(this FileInfo fileInfo)
        {
            var lines = new List<string>();
            using (var reader = new StreamReader(fileInfo.FullName))
            {
                string line;
                int lineNum = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    if (lineNum % 2 == 0)
                    {
                        line = line.Trim();
                    }
                }
            }
            return lines;
        }
    }
}