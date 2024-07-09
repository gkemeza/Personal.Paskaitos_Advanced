namespace Paskaita6_MiniProjektas
{
    internal class AddressBook
    {
        internal void AddContact()
        {
            Console.WriteLine("Vardas:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Pavarde:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Tel. nr.:");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("El. pastas:");
            string email = Console.ReadLine();
            Contact contact = new Contact(firstName, lastName, phoneNumber, email);

            string contents = $"{contact.FirstName} {contact.LastName} -> " +
                $"{contact.PhoneNumber}, {contact.Email}";
            string path = "contacts.csv";

            File.AppendAllText(path, contents + Environment.NewLine);
        }

        internal void ViewContacts()
        {
            string path = "contacts.csv";
            string[] contacts = File.ReadAllLines(path);
            for (int i = 0; i < contacts.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {contacts[i]}");
            }
        }

        internal void DeleteContact()
        {
            ViewContacts();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Irasykite istrinamo kontakto numeri (pvz.: '1'):");
            int contactId = int.Parse(Console.ReadLine());

            string path = "contacts.csv";
            string[] contacts = File.ReadAllLines(path);
            var list = contacts.ToList();

            for (int i = 0; i < list.Count; i++)
            {
                if (contactId == i + 1)
                {
                    list.RemoveAt(i);
                }
            }
            File.WriteAllLines(path, list);
        }

        internal void SearchContact()
        {

        }
    }
}
