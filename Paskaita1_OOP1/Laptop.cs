namespace Paskaita1_OOP1
{
    // primary constructor (since c# 12)
    internal class Laptop(string name, DateTime duildDate, string graphicsCard, string cpu, int ram, bool hasFloppy)
    {

        public string Name { get; set; } = name;
        public DateTime BuildDate { get; set; } = duildDate;
        public string GraphicsCard { get; set; } = graphicsCard;
        public string CPU { get; set; } = cpu;
        public int RAM { get; set; } = ram;
        public bool HasFloppyDisk { get; set; } = hasFloppy;

        public Engine Engine { get; set; }
    }
}