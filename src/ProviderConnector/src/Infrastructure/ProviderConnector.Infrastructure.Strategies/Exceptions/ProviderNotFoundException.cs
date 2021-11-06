namespace ProviderConnector.Infrastructure.Strategies.Exceptions;

public class ProviderNotFoundException : Exception
{
    public ProviderNotFoundException() : base("No Provider Can't be found with provided id.")
    {
    }
}