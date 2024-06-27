namespace Paskaita1_OOP1
{
    // #4
    internal class Store
    {
        public Store(int openingYear, List<string> productsNames, string name)
        {
            OpeningYear = openingYear;
            ProductsNames = productsNames;
            Name = name;
        }

        public int OpeningYear { get; set; }
        public List<string> ProductsNames { get; set; }
        public string Name { get; set; }
    }
}
