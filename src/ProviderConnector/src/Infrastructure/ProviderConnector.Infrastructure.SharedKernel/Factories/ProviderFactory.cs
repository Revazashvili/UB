using System.Reflection;
using ProviderConnector.Core.Providers.Attributes;
using ProviderConnector.Core.Providers.Exceptions;
using ProviderConnector.Core.Providers.Interfaces;
using ProviderConnector.Infrastructure.SharedKernel.Brokers;

namespace ProviderConnector.Infrastructure.SharedKernel.Factories;

/// <summary>
///     Factory for creating <see cref="IProvider" /> objects.
/// </summary>
public interface IProviderFactory
{
    /// <summary>
    ///     Creates <see cref="IProvider" /> instance based on the provider identifier.
    /// </summary>
    /// <param name="providerId">The provider identifier.</param>
    /// <returns><see cref="IProvider" /> instance.</returns>
    IProvider CreateProvider(int providerId);
}

public class ProviderFactory : IProviderFactory
{
    private readonly ITypeBroker _typeBroker;

    public ProviderFactory(ITypeBroker typeBroker)
    {
        _typeBroker = typeBroker;
    }

    public IProvider CreateProvider(int providerId)
    {
        foreach (var type in _typeBroker.GetAllTypeWithProviderAttribute())
        {
            var providerAttribute = (ProviderAttribute)type.GetCustomAttribute(typeof(ProviderAttribute))!;
            if (providerAttribute.ProviderId == providerId)
                return (IProvider)Activator.CreateInstance(type)!;
        }

        throw new ProviderNotCreatedException();
    }
}