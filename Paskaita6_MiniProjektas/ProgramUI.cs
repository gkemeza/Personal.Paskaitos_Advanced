namespace Paskaita6_MiniProjektas
{
    public class ProgramUI
    {
        private AddressBook addressBook = new AddressBook();

        public void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("\tMENIU");
            Console.WriteLine("1. Prideti kontakta");
            Console.WriteLine("2. Perziureti kontaktus");
            Console.WriteLine("3. Istrinti kontakta");
            Console.WriteLine("4. Ieskoti kontakto");
            Console.WriteLine("q. Iseiti");
        }

        public void HandleUserChoice()
        {
            string userInput = Console.ReadLine().ToLower();
            var availableChoices = new List<string>
            {
                "1", "2", "3", "4", "q"
            };

            while (!availableChoices.Contains(userInput))
            {
                ShowMenu();
                Console.WriteLine("Klaida! Iveskite tinkama meniu pasirinkima:");
                userInput = Console.ReadLine().ToLower();
            }

            switch (userInput)
            {
                case "1":
                    addressBook.AddContact();
                    break;
                case "2":
                    addressBook.ViewContacts();
                    break;
                case "3":
                    addressBook.DeleteContact();
                    break;
                case "4":
                    addressBook.SearchContact();
                    break;
                case "q":
                    Environment.Exit(0);
                    break;
            }
        }
    }
}