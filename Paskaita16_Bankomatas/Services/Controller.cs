using Paskaita16_Bankomatas.Services.Interfaces;

namespace Paskaita16_Bankomatas.Services
{
    public class Controller : IController
    {
        private readonly ICardService _cardService;
        private readonly ITransactionService _transactionService;
        private readonly IUserInterface _userInterface;

        public Controller(ICardService cardService, ITransactionService transactionService, IUserInterface userInterface)
        {
            _cardService = cardService;
            _transactionService = transactionService;
            _userInterface = userInterface;
        }

        public void ProcessMainMenuOption(Guid id)
        {
            string option = _userInterface.GetMainMenuOption();
            CallChosenOptionMethod(id, option);
        }

        public void CallChosenOptionMethod(Guid id, string option)
        {
            Console.Clear();
            switch (option)
            {
                case "1":
                    Console.WriteLine($"Likutis: {_cardService.GetBalance(id)} Eur");
                    Console.WriteLine("q. Atgal");
                    Console.ReadLine();
                    break;
                case "2":
                    _transactionService.WithdrawCash(id);
                    Console.WriteLine("q. Atgal");
                    Console.ReadLine();
                    break;
                case "3":
                    _transactionService.DisplayTransactions(id);
                    Console.WriteLine("q. Atgal");
                    Console.ReadLine();
                    break;
                case "q":
                    Console.WriteLine("Pasiimkite kortele");
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
