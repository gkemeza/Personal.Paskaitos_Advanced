namespace Paskaita9_MiniProjektas
{
    internal class FoodItem : InventoryItem
    {
        private const string filePath = @"..\..\..\maistas.csv";

        public FoodItem(string name, double weight, DateOnly expirationDate, int calories)
        {
            Name = name;
            Weight = weight;
            FilePath = filePath;
            ExpirationDate = expirationDate;
            Calories = calories;
        }
        public FoodItem()
        {
            FilePath = filePath;
        }

        public int Calories { get; private set; }
        public DateOnly ExpirationDate { get; private set; }

        public override string ToString()
        {
            return $"{Name}, {Weight}kg, {ExpirationDate}, {Calories}kcal";
        }

        public override string ParseToCsv()
        {
            return $"{Name}, {Weight}kg, {ExpirationDate}, {Calories}kcal" +
                Environment.NewLine;
        }
    }
}
