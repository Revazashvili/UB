using ProviderConnector.Core.Models.Common;
namespace ProviderConnector.Infrastructure.Strategies.GetBalanceStrategy.Factory;

public interface IProviderFactory
{
    ValueTask<IProvider> BuildProviderAsync(string providerName);
}