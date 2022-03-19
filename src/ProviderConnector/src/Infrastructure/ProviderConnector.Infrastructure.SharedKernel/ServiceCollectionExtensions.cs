using Microsoft.Extensions.DependencyInjection;
using ProviderConnector.Infrastructure.SharedKernel.Brokers;
using ProviderConnector.Infrastructure.SharedKernel.Factories;

namespace ProviderConnector.Infrastructure.SharedKernel;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddProviderFactory(this IServiceCollection services)
    {
        services.AddScoped<ITypeProvider, TypeProvider>();
        services.AddScoped<IProviderFactory, ProviderFactory>();
        return services;
    }
}