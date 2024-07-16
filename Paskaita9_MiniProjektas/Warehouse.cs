namespace Paskaita9_MiniProjektas
{
    internal class Warehouse<T> where T : InventoryItem, new()
    {
        private readonly string filePath;

        public Warehouse()
        {
            T tempObj = new T();
            filePath = tempObj.FilePath;
        }

        public void AddItem(T item)
        {
            File.AppendAllText(item.FilePath, item.ParseToCsv());
        }

        public List<T> GetItems()
        {
            var allLines = File.ReadAllLines(filePath).ToList();
            var result = new List<T>();
            foreach (var line in allLines)
            {
                result.Add(ParseFromCsv(line));
            }
            return result;
        }

        public T GetItem(string name)
        {
            var allItems = GetItems();

            foreach (var item in allItems)
            {
                if (string.Equals(item.Name.Trim(), name.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    return item;
                }
            }

            throw new ArgumentException("There is no such name");
        }

        private T ParseFromCsv(string line)
        {
            var columns = line.Trim().Split(',');
            if (typeof(T) == typeof(FoodItem))
            {
                if (columns.Length == 4)
                {
                    string name = columns[0].Trim();
                    double weight = double.Parse(columns[1].Trim().TrimEnd('k', 'g'));
                    DateOnly expirationDate = DateOnly.Parse(columns[2].Trim());
                    int calories = int.Parse(columns[3].Trim().TrimEnd('k', 'c', 'a', 'l'));

                    return (T)(object)new FoodItem(name, weight, expirationDate, calories);
                }
            }
            else if (typeof(T) == typeof(WeaponItem))
            {
                if (columns.Length == 3)
                {
                    string name = columns[0].Trim();
                    double weight = double.Parse(columns[1].Trim().TrimEnd('k', 'g'));
                    int damage = int.Parse(columns[2].Trim().TrimEnd('d', 'm', 'g'));

                    return (T)(object)new WeaponItem(name, weight, damage);
                }
            }
            else if (typeof(T) == typeof(MedicalItem))
            {
                if (columns.Length == 4)
                {
                    string name = columns[0].Trim();
                    double weight = double.Parse(columns[1].Trim().TrimEnd('k', 'g'));
                    DateOnly expirationDate = DateOnly.Parse(columns[2].Trim());
                    string treatedDiseases = columns[3].Trim();

                    return (T)(object)new MedicalItem(name, weight, expirationDate, treatedDiseases);
                }
            }

            throw new Exception();
        }
    }
}