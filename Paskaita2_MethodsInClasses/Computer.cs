// paskaita (copy)
namespace Paskaita2_MethodsInClasses
{
    internal class Computer
    {
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

        public string Name { get; set; }
        public DateTime BuildDate { get; set; }
        public string GraphicsCard { get; set; }
        public string CPU { get; set; }
        public int RAM { get; set; }
        public bool HasFloppyDisk { get; set; }
        public List<App> Apps { get; set; }

        public void PrintInfo()
        {
            foreach (var app in Apps)
            {
                Console.WriteLine($"Name: {app.Name}, Size: {app.Size}");
            }
        }
        public void PrintInfo(int sizeLimit)
        {
            foreach (var app in Apps)
            {
                if (app.Size <= sizeLimit)
                {
                    Console.WriteLine($"Name: {app.Name}, Size: {app.Size}");
                }
            }
        }

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
