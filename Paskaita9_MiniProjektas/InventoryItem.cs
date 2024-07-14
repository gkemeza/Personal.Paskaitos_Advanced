namespace Paskaita9_MiniProjektas
{
    internal abstract class InventoryItem
    {
        //public InventoryItem(double weight, string filePath)
        //{
        //    Weight = weight;
        //    FilePath = filePath;
        //}

        public double Weight { get; set; }
        public string FilePath { get; protected set; }
    }

    internal class FoodItem : InventoryItem
    {
        public FoodItem(double weight, DateTime expirationDate, int calories)
        {
            Weight = weight;
            FilePath = "maistas.csv";
            ExpirationDate = expirationDate;
            Calories = calories;
        }
        public FoodItem()
        {
            FilePath = "maistas.csv";
        }

        public int Calories { get; set; }
        public DateTime ExpirationDate { get; set; }

        public override string ToString()
        {
            return $"{Weight}, {ExpirationDate}, {Calories}";
        }
    }

    internal class WeaponItem : InventoryItem
    {
        public WeaponItem(double weight, int damage)
        {
            Weight = weight;
            FilePath = "ginklai.csv";
            Damage = damage;
        }
        public WeaponItem()
        {
            FilePath = "ginklai.csv";
        }

        public int Damage { get; set; }

        public override string ToString()
        {
            return $"Weight: {Weight}, Damage: {Damage}";
        }
    }

    internal class MedicalItem : InventoryItem
    {
        public MedicalItem(double weight, DateTime expirationDate, string treatedDiseases)
        {
            Weight = weight;
            FilePath = "vaistai.csv";
            ExpirationDate = expirationDate;
            TreatedDiseases = treatedDiseases;
        }
        public MedicalItem()
        {
            FilePath = "vaistai.csv";
        }

        public DateTime ExpirationDate { get; set; }
        public string TreatedDiseases { get; set; }

        public override string ToString()
        {
            return $"Weight: {Weight}, ExpirationDate: {ExpirationDate}, " +
                $"TreatedDiseases: {TreatedDiseases}";
        }
    }
}
