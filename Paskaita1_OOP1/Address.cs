namespace Paskaita1_OOP1
{
    internal class Address
    {
        public Address(string city, string street)
        {
            City = city;
            Street = street;
        }

        public string City { get; set; }
        public string Street { get; set; }
    }
}
