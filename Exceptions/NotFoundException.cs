namespace LauraSanchez.Portfolio.API.Exceptions
{
    public class NotFoundException : Exception
    {
        public NotFoundException(string resource)
            : base($"{resource} was not found.")
        {
        }
    }
}