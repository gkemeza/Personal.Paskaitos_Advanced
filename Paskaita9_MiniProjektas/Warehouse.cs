using System.Reflection;

namespace Paskaita9_MiniProjektas
{
    internal class Warehouse<T> where T : InventoryItem, new()
    {
        public void AddItem(T item)
        {
            File.AppendAllText(item.FilePath, item.ToString() + Environment.NewLine);
        }

        public List<T> GetItems()
        {
            T tempObj = new T();
            string filePath = tempObj.FilePath;
            // gauna visas klases ypatybes
            var properties = tempObj.GetType().GetProperties();

            var allLines = File.ReadAllLines(filePath).ToList();
            var headers = allLines[0].Trim().Split(',');
            allLines.RemoveAt(0);

            var result = new List<T>();
            foreach (var line in allLines)
            {
                T itemObj = new T();
                var columns = line.Trim().Split(',');

                for (int i = 0; i < columns.Length; i++)
                {
                    PropertyInfo matchedProperty = null;

                    // randa atitinkamos klasės ypatybę iš csv antraščių
                    for (int j = 0; j < properties.Length; j++)
                    {
                        if (string.Equals(properties[j].Name, headers[i], StringComparison.OrdinalIgnoreCase))
                        {
                            matchedProperty = properties[j];
                            break;
                        }
                    }

                    if (matchedProperty != null)
                    {
                        // nustato objekto ypatybės reikšmę
                        matchedProperty.SetValue(itemObj, Convert.ChangeType(columns[i], matchedProperty.PropertyType));
                    }
                }

                result.Add(itemObj);
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

        public void AddHeader()
        {
            T tempObj = new T();
            string filePath = tempObj.FilePath;
            var properties = tempObj.GetType().GetProperties();

            var headerNames = new List<string>();
            for (int i = 0; i < properties.Length; i++)
            {
                headerNames.Add(properties[i].Name);
            }
            string headerLine = string.Join(",", headerNames);
            File.AppendAllText(filePath, headerLine + Environment.NewLine);
        }
    }
}
