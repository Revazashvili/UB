namespace ProviderConnector.Infrastructure.Factories.Factories.Implementations;
using Interfaces;
using System.Reflection;
using Core.Providers.Attributes;
using Core.Providers.Exceptions;
using Core.Providers.Interfaces;
using Brokers.Interfaces;

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