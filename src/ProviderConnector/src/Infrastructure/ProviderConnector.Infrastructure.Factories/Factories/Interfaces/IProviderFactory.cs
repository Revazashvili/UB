namespace ProviderConnector.Infrastructure.Factories.Factories.Interfaces;
using ProviderConnector.Core.Providers.Interfaces;

public interface IProviderFactory
{
    /// <summary>
    /// Creates <see cref="IProvider"/> instance based on the provider identifier.
    /// </summary>
    /// <param name="providerId">The provider identifier.</param>
    /// <returns><see cref="IProvider"/> instance.</returns>
    IProvider CreateProvider(int providerId);
}