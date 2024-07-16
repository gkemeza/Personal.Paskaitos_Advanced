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
            File.AppendAllText(item.FilePath, item.ParseToCsv(item));
        }

        public List<T> GetItems()
        {
            var allLines = File.ReadAllLines(filePath).ToList();
            var result = new List<T>();
            foreach (var line in allLines)
            {
                var columns = line.Trim().Split(',');
                if (typeof(T) == typeof(FoodItem))
                {
                    if (columns.Length == 4)
                    {
                        var foodItem = new FoodItem(
                            double.Parse(columns[0]),
                            columns[1],
                            DateOnly.Parse(columns[2]),
                            int.Parse(columns[3])
                        );
                        result.Add((T)(object)foodItem);
                    }

                }
                else if (typeof(T) == typeof(WeaponItem))
                {
                    if (columns.Length == 3)
                    {
                        var weaponItem = new WeaponItem(
                            double.Parse(columns[0]),
                            columns[1],
                            int.Parse(columns[2])
                        );
                        result.Add((T)(object)weaponItem);
                    }
                }
                else if (typeof(T) == typeof(MedicalItem))
                {
                    if (columns.Length == 4)
                    {
                        var medicalItem = new MedicalItem(
                            double.Parse(columns[0]),
                            columns[1],
                            DateOnly.Parse(columns[2]),
                            columns[3]
                        );
                        result.Add((T)(object)medicalItem);
                    }

                }
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

            throw new ArgumentException("Tokio vardo nera");
        }

        public string ParseFromCsv()
        {
            throw new NotImplementedException();
        }
    }
}