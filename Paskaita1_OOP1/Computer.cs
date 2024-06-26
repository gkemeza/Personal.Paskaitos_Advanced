// paskaita
namespace Paskaita1_OOP1
{
    // Sablonas
    internal class Computer
    {
        // constructor
        public Computer()
        {
            BuildDate = DateTime.Now;
        }

        public Computer(string name) : this()
        {
            Name = name;
        }

        public Computer(string name1, string graphicsCard, string cpu, int ram, bool hasFloppy) : this(name1)
        {
            GraphicsCard = graphicsCard;
            CPU = cpu;
            RAM = ram;
            HasFloppyDisk = hasFloppy;
        }

        // auto-implemented properties
        // (kai nereikia papildomos logikos in property,
        // nereikia nustatyti field for a property,
        // reikia tik parasyti get; ir/arba set; inside the property)
        // get: read, set: write
        public string Name { get; set; }
        public DateTime BuildDate { get; set; }
        public string GraphicsCard { get; set; }
        public string CPU { get; set; }
        public int RAM { get; set; }
        public bool HasFloppyDisk { get; set; }

        // class methods
        // geriau naudoti ToString()
        public void PrintInfo()
        {
            // senesnese versijose rasydavosi su this
            //Console.WriteLine(this.Name);
            Console.WriteLine(Name);
            Console.WriteLine(BuildDate);
            Console.WriteLine(CPU);
            Console.WriteLine(GraphicsCard);
            Console.WriteLine(RAM);
            Console.WriteLine(HasFloppyDisk);
        }

        // geresnis PrintInfo() variantas (toks turetu buti)
        // kiekviena klase jau turi sita metoda
        // su override galima perrasyti
        public override string ToString()
        {
            return $"""
                Name: {Name}
                Build date: {BuildDate}
                CPU: {CPU}
                GraphicsCard: {GraphicsCard}
                RAM: {RAM}
                HasFloppyDisk: {HasFloppyDisk}
                """;
        }

        public string IsEnoughRAM()
        {
            switch (RAM)
            {
                case < 8:
                    return "Not Enough";
                case < 16:
                    return "Enough";
                case >= 16:
                    return "A lot";
            }
        }
    }
}
