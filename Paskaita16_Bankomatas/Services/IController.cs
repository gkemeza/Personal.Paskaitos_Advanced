
namespace Paskaita16_Bankomatas.Services
{
    public interface IController
    {
        void CallChosenOptionMethod(Guid id, string option);
        public void ProcessMainMenuOption(Guid id);
    }
}