namespace Paskaita16_Bankomatas.Services
{
    public class UserInterface : IUserInterface
    {
        private readonly IValidation _validation;
        private readonly ITransactionService _transactionService;
        private readonly ICardService _cardService;

        public UserInterface(ICardService cardService, ITransactionService transaction, IValidation validation)
        {
            _cardService = cardService;
            _transactionService = transaction;
            _validation = validation;
        }

        public void DisplayMainMenu()
        {
            Console.WriteLine("1. Balansas");
            Console.WriteLine("2. Pinigu isemimas");
            Console.WriteLine("3. Transakcijos");
            Console.WriteLine("q. Iseiti");
        }
        public void DisplayBalance()
        {
            throw new NotImplementedException();
        }

        public void DisplayWithdrawalMenu()
        {
            throw new NotImplementedException();
        }

        public void ProcessMainMenuOption()
        {
            string option = ReturnMainMenuOption();
            CallChosenOptionMethod(option);
        }

        public string ReturnMainMenuOption()
        {
            DisplayMainMenu();

            string option = Console.ReadLine();

            if (_validation.IsValidMenuOption(option))
            {
                return option;
            }
            else
            {
                Console.Clear();
                return ReturnMainMenuOption();
            }
        }

        public void CallChosenOptionMethod(string option)
        {
            Console.Clear();
            switch (option)
            {
                case "1":
                    _transactionService.CheckBalance();
                    break;
                case "2":
                    _transactionService.WithdrawCash();
                    break;
                case "3":
                    _transactionService.GetPastTransactions();
                    break;
                case "q":
                    Console.WriteLine("Exiting...");
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
