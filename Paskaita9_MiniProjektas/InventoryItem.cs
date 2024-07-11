using System.ComponentModel.DataAnnotations;

namespace Paskaita9_MiniProjektas
{
    internal abstract class InventoryItem
    {
        public double Weight { get; set; }
        public string FilePath { get; protected set; }
    }

    internal class FoodItem : InventoryItem
    {
        public FoodItem(double weight, DateTime expirationDate, int calories)
        {
            FilePath = "maistas.csv";
            Weight = weight;
            ExpirationDate = expirationDate;
            Calories = calories;
        }

        public DateTime ExpirationDate { get; set; }
        public int Calories { get; set; }

        public override string ToString()
        {
            return $"Weight: {Weight}kg, ExpirationDate: {ExpirationDate}, " +
                $"Calories: {Calories}kcal";
        }
    }

    internal class WeaponItem : InventoryItem
    {
        public WeaponItem(double weight, int damage)
        {
            FilePath = "ginklai.csv";
            Weight = weight;
            Damage = damage;
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
            FilePath = "vaistai.csv";
            Weight = weight;
            ExpirationDate = expirationDate;
            TreatedDiseases = treatedDiseases;
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
