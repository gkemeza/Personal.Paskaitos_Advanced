namespace Paskaita16_Bankomatas.Services
{
    public interface IUserInterface
    {
        void DisplayBalance();
        void DisplayMainMenu();
        void DisplayWithdrawalMenu();
        public void DisplayPromptForWithdraw();
        public int PromptForWithdraw();
        public void FillTestCards();
        public bool TryToGetCard(out Guid id);
        public string GetMainMenuOption();
    }
}
