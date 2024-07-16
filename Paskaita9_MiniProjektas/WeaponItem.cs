namespace Paskaita9_MiniProjektas
{
    internal class WeaponItem : InventoryItem
    {
        private int Damage { get; set; }
        public override string FilePath { get; protected set; } = @"..\..\..\ginklai.csv";

        public WeaponItem()
        {
        }

        public WeaponItem(string name, double weight, int damage)
        {
            Name = name;
            Weight = weight;
            Damage = damage;
        }

        public override string ParseToCsv()
        {
            return $"{Name}, {Weight}kg, {Damage}dmg {Environment.NewLine}";
        }

        public override void ParseFromCsv(string line)
        {
            var columns = line.Trim().Split(',');
            if (columns.Length == 3)
            {
                Name = columns[0].Trim();
                Weight = double.Parse(columns[1].Trim().TrimEnd('k', 'g'));
                Damage = int.Parse(columns[2].Trim().TrimEnd('d', 'm', 'g'));
            }
        }
    }
}
