using Paskaita16_Bankomatas.Services;
using Paskaita16_Bankomatas.Models;

namespace Paskaita16_Bankomatas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICardService cardService = new CardService(@"..\..\..\CardInfo.csv");
            IUserInterface ui = new UserInterface(cardService, new Validation());
            ITransactionService transactionService = new TransactionService(cardService, ui);
            IController controller = new Controller(cardService, transactionService, ui);

            while (true)
            {
                ui.FillTestCards();

                if (ui.TryToGetCard(out Guid id))
                {
                    while (true)
                    {
                        controller.ProcessMainMenuOption(id);
                    }
                }
            }
        }
    }
}
