namespace Paskaita9_MiniProjektas
{
    internal class MedicalItem : InventoryItem
    {
        private const string filePath = @"..\..\..\vaistai.csv";

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
            return $"{Weight},{Name},{ExpirationDate},{TreatedDiseases}";
        }
    }
}
