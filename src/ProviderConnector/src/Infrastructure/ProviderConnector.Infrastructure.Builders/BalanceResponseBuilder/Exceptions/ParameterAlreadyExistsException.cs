namespace ProviderConnector.Infrastructure.Builders.BalanceResponseBuilder.Exceptions;

public class ParameterAlreadyExistsException : Exception
{
    private ParameterAlreadyExistsException() : base("Parameter with provided key already exists.")
    {
    }

    public static ParameterAlreadyExistsException Instance { get; } = new();
}