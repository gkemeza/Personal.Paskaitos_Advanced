using Paskaita16_Bankomatas.Models;

namespace Paskaita16_Bankomatas.Services
{
    public class UserInterface : IUserInterface
    {
        private readonly IValidation _validation;
        private readonly ITransactionService _transactionService;
        private readonly ICardService _cardService;
        private readonly IController _controller;

        public UserInterface(ICardService cardService, IValidation validation)
        {
            _cardService = cardService;
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

        // TODO: validation
        public int PromptForWithdraw()
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

        public void DisplayPromptForWithdraw()
        {
            Console.Clear();
            Console.WriteLine($"Iveskite issigryninama suma (turi dalintis is 5):");
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

    }
}
