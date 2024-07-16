namespace Paskaita9_MiniProjektas
{
    internal abstract class InventoryItem
    {
        public double Weight { get; protected set; }
        public string Name { get; protected set; }
        public string FilePath { get; protected set; }

        public abstract string ParseToCsv(InventoryItem item);
    }
}
