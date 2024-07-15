namespace Paskaita9_MiniProjektas
{
    internal class FoodItem : InventoryItem
    {
        private const string filePath = @"..\..\..\maistas.csv";

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
            return $"{Weight},{Name},{ExpirationDate},{Calories}";
        }
    }
}
