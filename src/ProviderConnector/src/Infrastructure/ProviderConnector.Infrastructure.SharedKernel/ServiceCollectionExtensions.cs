using Microsoft.Extensions.DependencyInjection;
using ProviderConnector.Infrastructure.SharedKernel.Brokers;
using ProviderConnector.Infrastructure.SharedKernel.Factories;

namespace ProviderConnector.Infrastructure.SharedKernel;

/// <summary>
///     Extension class for <see cref="IServiceCollection" /> interface.
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    ///     Adds <see cref="IProviderFactory" /> interface into DI Container.
    /// </summary>
    public static IServiceCollection AddProviderFactory(this IServiceCollection services)
    {
        services.AddScoped<ITypeProvider, TypeProvider>();
        services.AddScoped<IProviderFactory, ProviderFactory>();
        return services;
    }
}