using Microsoft.Extensions.DependencyInjection;

namespace ProviderConnector.Client.SDK;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddProviderConnector(this IServiceCollection services,Action<ProviderConnectorOptions> action)
    {
        var options = GetOptions(action);
        
        // inject clients here
        
        return services;
    }

    public static ProviderConnectorOptions GetOptions(Action<ProviderConnectorOptions> action)
    {
        var options = new ProviderConnectorOptions();
        action.Invoke(options);
        return options;
    }
}