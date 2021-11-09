namespace ProviderConnector.Core.Providers.Exceptions;

/// <summary>
/// Exception to throw when broker can't create instance of specified provider.
/// </summary>
public class ProviderNotCreatedException : Exception
{
    /// <summary>
    /// Initializes new instance of <see cref="ProviderNotCreatedException"/>.
    /// </summary>
    public ProviderNotCreatedException() : base("Can't create provider instance.")
    {
    }

    /// <summary>
    /// Initializes new instance of <see cref="ProviderNotCreatedException"/>.
    /// </summary>
    /// <param name="providerId">The provider identifier.</param>
    public ProviderNotCreatedException(int providerId) 
        : base($"Can't create provider instance with id: {providerId}.")
    {
    }
}