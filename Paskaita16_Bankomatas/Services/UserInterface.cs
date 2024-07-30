using Paskaita16_Bankomatas.Models;

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

        public void FillTestCards()
        {
            _cardService.SaveTestCards();
        }

        public bool TryToGetCard(out Guid id)
        {
            DisplayPromptForId();
            id = PromptForCardId();

            if (_cardService.IsCorrectId(id))
            {
                if (TryToGetCardPin(id))
                {
                    _cardService.GetCard(id);
                    return true;
                }
            }
            return false;
        }

        public bool TryToGetCardPin(Guid id)
        {
            for (int i = 3; i > 0; i--)
            {
                DisplayPromptForPin(i);
                int pin = PromptForCardPin();

                if (_cardService.IsCorrectPin(id, pin))
                {
                    return true;
                }
            }
            return false;
        }



        // TODO: validation
        public Guid PromptForCardId()
        {
            return Guid.Parse(Console.ReadLine());
        }

        // TODO: validation
        public int PromptForCardPin()
        {
            return int.Parse(Console.ReadLine());
        }

        public void DisplayPromptForId()
        {
            Console.Clear();
            Console.WriteLine("Iveskite korteles numeri (Id):");
        }

        public void DisplayPromptForPin(int i)
        {
            Console.Clear();
            Console.WriteLine($"Iveskite korteles Pin (Liko {i} bandymai):");
        }

        public void DisplayMainMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Balansas");
            Console.WriteLine("2. Pinigu isemimas");
            Console.WriteLine("3. Transakcijos");
            Console.WriteLine("q. Grazinti kortele");
        }
        public void DisplayBalance()
        {
            throw new NotImplementedException();
        }

        public void DisplayWithdrawalMenu()
        {
            throw new NotImplementedException();
        }

        public void ProcessMainMenuOption(Guid id)
        {
            string option = GetMainMenuOption();
            CallChosenOptionMethod(id, option);
        }

        public string GetMainMenuOption()
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
                return GetMainMenuOption();
            }
        }

        public void CallChosenOptionMethod(Guid id, string option)
        {
            Console.Clear();
            switch (option)
            {
                case "1":
                    Console.WriteLine($"Balansas: {_cardService.GetBalance(id)} Eur");
                    Console.WriteLine("q. Atgal");
                    Console.ReadLine();
                    break;
                case "2":
                    _transactionService.WithdrawCash();
                    break;
                case "3":
                    _transactionService.GetPastTransactions();
                    break;
                case "q":
                    Console.WriteLine("Pasiimkite kortele");
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
