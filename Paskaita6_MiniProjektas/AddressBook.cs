namespace Paskaita6_MiniProjektas
{
    public class AddressBook
    {
        private const string filePath = "contacts.csv";

        public void AddContact()
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

            File.AppendAllText(filePath, contents + Environment.NewLine);
        }

        public void ViewContacts()
        {
            Console.Clear();
            string[] contacts = File.ReadAllLines(filePath);
            PrintContacts(contacts);

            Console.WriteLine("Enter - testi");
            Console.ReadLine();
        }

        public void DeleteContact()
        {
            Console.Clear();
            string[] contacts = File.ReadAllLines(filePath);
            PrintContacts(contacts);

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Irasykite istrinamo kontakto numeri (pvz.: '1'):");
            int contactId = int.Parse(Console.ReadLine());

            var list = contacts.ToList();
            var newList = RemoveContact(list, contactId);
            File.WriteAllLines(filePath, newList);
        }

        private List<string> RemoveContact(List<string> list, int contactId)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (contactId == i + 1)
                {
                    list.RemoveAt(i);
                    break;
                }
            }
            return list;
        }

        public void SearchContact()
        {
            Console.Clear();
            Console.WriteLine("Iveskite ieskomo kontakto varda arba pavarde:");
            string nameToSearch = Console.ReadLine().ToLower();

            var searchedContacts = GetSearchedContacts(nameToSearch);
            PrintContacts(searchedContacts);

            Console.WriteLine("Enter - testi");
            Console.ReadLine();
        }

        private List<string> GetSearchedContacts(string name)
        {
            var searchedContacts = new List<string>();
            string[] contacts = File.ReadAllLines(filePath);
            for (int i = 0; i < contacts.Length; i++)
            {
                if (contacts[i].ToLower().Contains(name.ToLower()))
                {
                    searchedContacts.Add(contacts[i]);
                }
            }
            return searchedContacts;
        }

        private void PrintContacts(IEnumerable<string> contacts)
        {
            for (int i = 0; i < contacts.Count(); i++)
            {
                Console.WriteLine($"{i + 1}. {contacts.ElementAt(i)}");
            }
        }
    }
}