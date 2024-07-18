namespace Paskaita10_ExceptionHandling
{
    internal class HasToBeLargerException : Exception
    {
        public HasToBeLargerException()
        {
        }

        public HasToBeLargerException(string? message) : base(message)
        {
        }
    }
}
