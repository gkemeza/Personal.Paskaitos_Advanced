using System.Globalization;

namespace Paskaita9_MiniProjektas
{
    internal class FoodItem : InventoryItem
    {
        private int Calories { get; set; }
        private DateOnly ExpirationDate { get; set; }
        public override string FilePath { get; protected set; } = @"..\..\..\maistas.csv";

        public FoodItem()
        {
        }

        public FoodItem(string name, double weight, DateOnly expirationDate, int calories)
        {
            Name = name;
            Weight = weight;
            ExpirationDate = expirationDate;
            Calories = calories;
        }

        public override string ParseToCsv()
        {
            return $"{Name}, {Weight.ToString(CultureInfo.InvariantCulture)}kg, {ExpirationDate.ToString(new CultureInfo("lt-LT"))}, {Calories}kcal";
        }

        public override void ParseFromCsv(string line)
        {
            var columns = line.Trim().Split(',');

            if (columns.Length == 4)
            {
                Name = columns[0].Trim();
                Weight = double.Parse(columns[1].Trim().TrimEnd('k', 'g'), CultureInfo.InvariantCulture);
                ExpirationDate = DateOnly.Parse(columns[2].Trim());
                Calories = int.Parse(columns[3].Trim().TrimEnd('k', 'c', 'a', 'l'));
            }
        }
    }
}
