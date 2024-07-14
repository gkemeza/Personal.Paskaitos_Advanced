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
            // Create a temporary instance of T to get the FilePath and properties
            T tempObj = new T();
            string filePath = tempObj.FilePath;
            //PropertyInfo[] properties = tempObj.GetType().GetProperties();

            var items = new List<T>();

            // need to convert to List<T>
            //if (typeof(T) == typeof(FoodItem))
            //{
            //}
            List<string> lines = File.ReadAllLines(filePath).Skip(1).ToList();
            List<string> headers = lines[0].Trim().Split(',').ToList();

            foreach (var line in lines)
            {
                T obj = new T();
                var columns = line.Trim().Split(',').ToList();
            }

            throw new NotImplementedException();
        }

        public T GetItem(string name)
        {
            // ??
            throw new NotImplementedException();
        }
    }
}
