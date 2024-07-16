namespace Paskaita9_MiniProjektas
{
    internal abstract class InventoryItem
    {
        public string Name { get; protected set; }
        public double Weight { get; protected set; }
        public string FilePath { get; protected set; }

        public abstract string ParseToCsv();
    }
}
