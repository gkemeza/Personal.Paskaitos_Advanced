namespace Paskaita16_Bankomatas.Services
{
    public class Validation : IValidation
    {
        private readonly string[] validOptions = { "1", "2", "3", "q" };

        public bool IsValidMenuOption(string option)
        {
            return validOptions.Contains(option);
        }
    }
}
