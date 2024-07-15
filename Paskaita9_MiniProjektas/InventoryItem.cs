namespace Paskaita9_MiniProjektas
{
    internal abstract class InventoryItem
    {
        public double Weight { get; protected set; }
        public string Name { get; protected set; }
        public string FilePath { get; protected set; }
    }

    internal class FoodItem : InventoryItem
    {
        private const string filePath = "maistas.csv";

        public FoodItem(double weight, string name, DateTime expirationDate, int calories)
        {
            Weight = weight;
            Name = name;
            FilePath = filePath;
            ExpirationDate = expirationDate;
            Calories = calories;
        }
        public FoodItem()
        {
            FilePath = filePath;
        }

        public int Calories { get; set; }
        public DateTime ExpirationDate { get; set; }

        public override string ToString()
        {
            return $"{Calories}, {ExpirationDate}, {Weight}, {Name}";
        }
    }

    internal class WeaponItem : InventoryItem
    {
        private const string filePath = "ginklai.csv";

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

    internal class MedicalItem : InventoryItem
    {
        private const string filePath = "vaistai.csv";

        public MedicalItem(double weight, string name, DateTime expirationDate, string treatedDiseases)
        {
            Weight = weight;
            Name = name;
            FilePath = filePath;
            ExpirationDate = expirationDate;
            TreatedDiseases = treatedDiseases;
        }
        public MedicalItem()
        {
            FilePath = filePath;
        }

        public DateTime ExpirationDate { get; set; }
        public string TreatedDiseases { get; set; }

        public override string ToString()
        {
            return $"{ExpirationDate}, {TreatedDiseases}, {Weight}, {Name}";
        }
    }
}
