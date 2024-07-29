using Paskaita16_Bankomatas.Services;

namespace Paskaita16_Bankomatas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserInterface ui = new UserInterface(new CardService(), new TransactionService(), new Validation());
            while (true)
            {
                ui.ProcessMainMenuOption();
            }
        }
    }
}
