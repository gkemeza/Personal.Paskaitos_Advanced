namespace Paskaita9_MiniProjektas
{
    internal class Warehouse<T> where T : InventoryItem
    {
        private readonly string filePath;

        public Warehouse()
        {
            T itemObject = (T)Activator.CreateInstance(typeof(T));
            filePath = itemObject.FilePath;
        }

        public void AddItem(T item)
        {
            File.AppendAllText(item.FilePath, item.ParseToCsv());
        }

        public List<T> GetItems()
        {
            if (File.Exists(filePath))
            {
                var allCsvLines = File.ReadAllLines(filePath).ToList();

                var items = new List<T>();
                foreach (var csvLine in allCsvLines)
                {
                    T itemObject = (T)Activator.CreateInstance(typeof(T));
                    itemObject.ParseFromCsv(csvLine);
                    items.Add(itemObject);
                }
                return items;
            }

            throw new FileNotFoundException($"File at '{filePath}' not found");
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
    }
}