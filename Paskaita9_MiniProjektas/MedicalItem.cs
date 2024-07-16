namespace Paskaita9_MiniProjektas
{
    internal class MedicalItem : InventoryItem
    {
        private const string filePath = @"..\..\..\vaistai.csv";

        public MedicalItem(string name, double weight, DateOnly expirationDate, string treatedDiseases)
        {
            Name = name;
            Weight = weight;
            FilePath = filePath;
            ExpirationDate = expirationDate;
            TreatedDiseases = treatedDiseases;
        }
        public MedicalItem()
        {
            FilePath = filePath;
        }

        public DateOnly ExpirationDate { get; private set; }
        public string TreatedDiseases { get; private set; }

        public override string ToString()
        {
            return $"{Name}, {Weight}kg, {ExpirationDate}, {TreatedDiseases}";
        }

        public override string ParseToCsv()
        {
            return $"{Name}, {Weight}kg, {ExpirationDate}, {TreatedDiseases}" +
                Environment.NewLine;
        }
    }
}
