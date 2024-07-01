namespace Paskaita2_MethodsInClasses
{
    internal class Computer2
    {
        public Computer2(string brand, string model, int ram, int storage)
        {
            Brand = brand;
            Model = model;
            RAM = ram;
            Storage = storage;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public int RAM { get; set; }
        public int Storage { get; set; }

        public bool IsEnoughRAM(int neededRam)
        {
            if (RAM >= neededRam)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
