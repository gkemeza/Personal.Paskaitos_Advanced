namespace Paskaita9_MiniProjektas
{
    internal abstract class InventoryItem
    {
        public string Name { get; protected set; }
        public double Weight { get; protected set; }
        public abstract string FilePath { get; protected set; }

        public abstract string ParseToCsv();
        public abstract void ParseFromCsv(string line);
    }
}
