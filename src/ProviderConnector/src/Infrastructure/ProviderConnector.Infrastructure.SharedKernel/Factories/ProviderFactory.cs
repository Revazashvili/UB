using System.Reflection;
using ProviderConnector.Core.Providers.Attributes;
using ProviderConnector.Core.Providers.Interfaces;
using ProviderConnector.Infrastructure.SharedKernel.Brokers;

namespace ProviderConnector.Infrastructure.SharedKernel.Factories;

public interface IProviderFactory
{
    IProvider CreateProvider(int providerId);
}

public class ProviderFactory : IProviderFactory
{
    private readonly ITypeProvider _typeProvider;
    public ProviderFactory(ITypeProvider typeProvider) => _typeProvider = typeProvider;

    public IProvider CreateProvider(int providerId) =>
        _typeProvider.GetAllTypeWithProviderAttribute()
            .Where(type => (type.GetCustomAttribute(typeof(ProviderAttribute)) as ProviderAttribute)!.ProviderId == providerId)
            .Select(type => (IProvider)Activator.CreateInstance(type)!)
            .FirstOrDefault()!;
}