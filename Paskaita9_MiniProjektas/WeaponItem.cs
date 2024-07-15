namespace Paskaita9_MiniProjektas
{
    internal class WeaponItem : InventoryItem
    {
        private const string filePath = @"..\..\..\ginklai.csv";

        public WeaponItem(double weight, string name, int damage)
        {
            Weight = weight;
            Name = name;
            FilePath = filePath;
            Damage = damage;
        }
        public WeaponItem()
        {
            FilePath = filePath;
        }

        public int Damage { get; set; }

        public override string ToString()
        {
            return $"{Damage}, {Weight}, {Name}";
        }
    }
}
