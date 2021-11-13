using Microsoft.Extensions.DependencyInjection;
using ProviderConnector.Infrastructure.Factories.Brokers.Implementations;
using ProviderConnector.Infrastructure.Factories.Brokers.Interfaces;
using ProviderConnector.Infrastructure.Factories.Factories.Implementations;
using ProviderConnector.Infrastructure.Factories.Factories.Interfaces;

namespace ProviderConnector.Infrastructure.Factories;

/// <summary>
/// Extension class for <see cref="IServiceCollection"/> interface.
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Adds <see cref="IProviderFactory"/> interface into DI Container.
    /// </summary>
    public static IServiceCollection AddProviderFactory(this IServiceCollection services)
    {
        services.AddScoped<ITypeBroker, TypeBroker>();
        services.AddScoped<IProviderFactory, ProviderFactory>();
        return services;
    }
}