using Paskaita16_Bankomatas.Services;
using Paskaita16_Bankomatas.Services.Interfaces;

namespace Paskaita16_Bankomatas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICardService cardService = new CardService(@"..\..\..\cardsInfo.json");
            IUserInterface ui = new UserInterface(cardService, new Validation());
            ITransactionService transactionService = new TransactionService(cardService, ui, @"..\..\..\transactionsInfo.json");
            IController controller = new Controller(cardService, transactionService, ui);

            cardService.SaveTestCards();

            if (ui.TryToGetCard(out Guid id))
            {
                ui.GreetUser(id);
                while (true)
                {
                    controller.ProcessMainMenuOption(id);
                }
            }
        }
    }
}
