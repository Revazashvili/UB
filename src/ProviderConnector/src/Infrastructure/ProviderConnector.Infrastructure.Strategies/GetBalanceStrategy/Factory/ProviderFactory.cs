namespace ProviderConnector.Infrastructure.Strategies.GetBalanceStrategy.Factory;
using Core.Models.Common;

public class ProviderFactory : IProviderFactory
{
    public ValueTask<Dictionary<int, IProvider>> GetCommonProvidersAsync()
    {
        var providerKeyValuePair = new Dictionary<int, IProvider>();
        return new ValueTask<Dictionary<int, IProvider>>(providerKeyValuePair);
    }
}