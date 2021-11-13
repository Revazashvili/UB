namespace ProviderConnector.Infrastructure.Builders.BalanceResponseBuilder.Exceptions;

public class ParameterNullException : Exception
{
    private ParameterNullException() : base("Provider parameter can't be null.")
    {
    }

    public static ParameterNullException Instance { get; } = new();
}