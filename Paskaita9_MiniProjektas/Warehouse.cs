using System.Reflection;

namespace Paskaita9_MiniProjektas
{
    internal class Warehouse<T> where T : InventoryItem
    {
        public void AddItem(T item)
        {
            File.AppendAllText(item.FilePath, item.ToString());
        }

        public List<T> GetItems()
        {
            //var inventoryItem = new InventoryItem();

            Assembly.GetAssembly(typeof(T).GetType());

            //File.ReadAllText(inventoryItem.FilePath);
            throw new NotImplementedException();
        }

        public T GetItem(string name)
        {
            // ??
            throw new NotImplementedException();
        }
    }
}
