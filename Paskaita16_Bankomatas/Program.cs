using Paskaita16_Bankomatas.Services;
using Paskaita16_Bankomatas.Models;

namespace Paskaita16_Bankomatas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserInterface ui = new UserInterface(
                new CardService(@"..\..\..\CardInfo.csv"), new TransactionService(), new Validation()
                );

            while (true)
            {
                ui.FillTestCards();

                if (ui.TryToGetCard(out Guid id))
                {
                    while (true)
                    {
                        ui.ProcessMainMenuOption(id);
                    }
                }
            }
        }
    }
}
