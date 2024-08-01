namespace Paskaita16_Bankomatas.Services.Interfaces
{
    public interface IUserInterface
    {
        void DisplayBalance();
        void DisplayMainMenu();
        void DisplayWithdrawalMenu();
        public void DisplayPromptForWithdraw();
        public int PromptForWithdraw();
        public bool TryToGetCard(out Guid id);
        public string GetMainMenuOption();
        public void GreetUser(Guid id);
    }
}
