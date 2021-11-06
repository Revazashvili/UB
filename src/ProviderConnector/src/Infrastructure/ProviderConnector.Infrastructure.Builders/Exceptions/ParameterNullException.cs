namespace ProviderConnector.Infrastructure.Builders.Exceptions;

public class ParameterNullException : Exception
{
    public ParameterNullException() : base("Provider parameter can't be null.")
    {
    }
}