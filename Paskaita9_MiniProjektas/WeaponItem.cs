namespace Paskaita9_MiniProjektas
{
    internal class WeaponItem : InventoryItem
    {
        private const string filePath = @"..\..\..\ginklai.csv";

        public WeaponItem(string name, double weight, int damage)
        {
            Name = name;
            Weight = weight;
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
            return $"{Name}, {Weight}kg, {Damage}dmg";
        }

        public override string ParseToCsv()
        {
            return $"{Name}, {Weight}kg, {Damage}dmg {Environment.NewLine}";
        }
    }
}
