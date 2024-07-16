namespace Paskaita9_MiniProjektas
{
    internal class Warehouse<T> where T : InventoryItem, new()
    {
        private readonly string filePath;

        public Warehouse()
        {
            filePath = new T().FilePath;
        }

        public void AddItem(T item)
        {
            File.AppendAllText(item.FilePath, item.ParseToCsv());
        }

        public List<T> GetItems()
        {
            var allCsvLines = File.ReadAllLines(filePath).ToList();

            var items = new List<T>();
            foreach (var csvLine in allCsvLines)
            {
                items.Add(ParseFromCsv(csvLine));
            }
            return items;
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

            throw new ArgumentException($"Item with name '{name}' not found.");
        }

        private T ParseFromCsv(string csvLine)
        {
            var columns = csvLine.Trim().Split(',');

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