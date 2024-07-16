namespace Paskaita9_MiniProjektas
{
    internal class Warehouse<T> where T : InventoryItem, new()
    {
        private readonly string _filePath;

        public Warehouse()
        {
            T itemObject = new T();
            _filePath = itemObject.FilePath;
        }

        public void AddItem(T item)
        {
            File.AppendAllText(item.FilePath, item.ParseToCsv() + Environment.NewLine);
        }

        public List<T> GetItems()
        {
            if (File.Exists(_filePath))
            {
                string[] allCsvLines = File.ReadAllLines(_filePath);

                var items = new List<T>();
                foreach (var csvLine in allCsvLines)
                {
                    if (!string.IsNullOrEmpty(csvLine))
                    {
                        T itemObject = new T();
                        itemObject.ParseFromCsv(csvLine);
                        items.Add(itemObject);
                    }
                }
                return items;
            }

            throw new FileNotFoundException($"File at '{_filePath}' not found");
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