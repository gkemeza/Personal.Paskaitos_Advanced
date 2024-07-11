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
            throw new NotImplementedException();
        }

        public T GetItem(string name)
        {
            throw new NotImplementedException();
        }
    }
}
