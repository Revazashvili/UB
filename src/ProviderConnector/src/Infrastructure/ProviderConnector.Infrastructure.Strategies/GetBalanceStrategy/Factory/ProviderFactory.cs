namespace ProviderConnector.Infrastructure.Strategies.GetBalanceStrategy.Factory;
using Core.Providers.FirstCategory;
using Core.Models.Common;

public class ProviderFactory : IProviderFactory
{
    public ValueTask<IProvider> BuildProviderAsync(string providerName) => new(new Telmico());
}