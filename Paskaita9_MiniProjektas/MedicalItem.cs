namespace Paskaita9_MiniProjektas
{
    internal class MedicalItem : InventoryItem
    {
        private DateOnly ExpirationDate { get; set; }
        private string TreatedDiseases { get; set; }
        public override string FilePath { get; protected set; } = @"..\..\..\vaistai.csv";

        public MedicalItem()
        {
        }

        public MedicalItem(string name, double weight, DateOnly expirationDate, string treatedDiseases)
        {
            Name = name;
            Weight = weight;
            ExpirationDate = expirationDate;
            TreatedDiseases = treatedDiseases;
        }

        public override string ParseToCsv()
        {
            return $"{Name}, {Weight}kg, {ExpirationDate}, {TreatedDiseases}" +
                Environment.NewLine;
        }

        public override void ParseFromCsv(string line)
        {
            var columns = line.Trim().Split(',');

            if (columns.Length == 4)
            {
                Name = columns[0].Trim();
                Weight = double.Parse(columns[1].Trim().TrimEnd('k', 'g'));
                ExpirationDate = DateOnly.Parse(columns[2].Trim());
                TreatedDiseases = columns[3].Trim();
            }
        }
    }
}
