using System.Reflection;

namespace Paskaita9_MiniProjektas
{
    internal class Warehouse<T> where T : InventoryItem, new()
    {
        public void AddItem(T item)
        {
            File.AppendAllText(item.FilePath, item.ToString() + Environment.NewLine);
        }

        // make multiple methods
        public List<T> GetItems()
        {
            // Create a temporary instance of T to get the FilePath and properties
            T tempObj = new T();
            string filePath = tempObj.FilePath;

            var result = new List<T>();
            List<string> lines = File.ReadAllLines(filePath).ToList();
            List<string> headers = lines[0].Trim().Split(',').ToList();
            // remove headers
            lines.RemoveAt(0);

            // get all class properties
            PropertyInfo[] properties = new T().GetType().GetProperties();

            foreach (var line in lines)
            {
                T item = new T();
                var columns = line.Trim().Split(',').ToList();

                for (int i = 0; i < columns.Count; i++)
                {
                    string columnHeader = headers[i];

                    // ??
                    // find the matching class property from csv headers
                    PropertyInfo? matchedProperties = properties
                        .Where(w => w.Name.ToLower().Equals(columnHeader.ToLower()))
                        .FirstOrDefault();

                    if (matchedProperties != null)
                    {
                        // set object attributes dynamically (convert to the correct attribute type when setting)
                        matchedProperties.SetValue(item, Convert.ChangeType(columns[i], matchedProperties.PropertyType));
                    }
                }
                result.Add(item);
            }
            return result;
        }


        public T GetItem(string name)
        {
            // ??
            throw new NotImplementedException();
        }

        public void AddHeader()
        {
            T tempObj = new T();
            string filePath = tempObj.FilePath;
            string headerLine = string.Join(",", typeof(T).GetProperties().Select(p => p.Name));
            File.AppendAllText(filePath, headerLine + Environment.NewLine);
        }
    }
}
