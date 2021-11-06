namespace ProviderConnector.Infrastructure.Builders.Exceptions;

public class ParameterAlreadyExistsException : Exception
{
    public ParameterAlreadyExistsException() : base("Parameter with provided key already exists.")
    {
    }
}