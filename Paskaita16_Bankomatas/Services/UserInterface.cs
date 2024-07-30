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

        public bool TryToGetCard()
        {
            DisplayPromptForId();
            Guid id = PromptForCardId();

            if (IsCorrectId(id))
            {
                if (TryToGetCardPin(id))
                {
                    GetCard(id);
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

                if (IsCorrectPin(id, pin))
                {
                    return true;
                }
            }
            return false;
        }

        public Card GetCard(Guid id)
        {
            var cards = _cardService.ReadCardsInfo();
            return cards.First(card => card.Id == id);
        }

        public bool IsCorrectId(Guid id)
        {
            var cards = _cardService.ReadCardsInfo();
            return cards.Any(card => card.Id == id);
        }

        public bool IsCorrectPin(Guid id, int pin)
        {
            var cards = _cardService.ReadCardsInfo();
            var card = cards.FirstOrDefault(card => card.Id == id);
            return card != null && card.Pin == pin;
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
                    _cardService.GetBalance();
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
