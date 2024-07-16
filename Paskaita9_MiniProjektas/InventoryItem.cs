namespace Paskaita9_MiniProjektas
{
    internal abstract class InventoryItem
    {
        public string Name { get; protected set; }
        protected double Weight { get; set; }
        public abstract string FilePath { get; protected set; }

        public abstract string ParseToCsv();
        public abstract void ParseFromCsv(string line);
    }
}
