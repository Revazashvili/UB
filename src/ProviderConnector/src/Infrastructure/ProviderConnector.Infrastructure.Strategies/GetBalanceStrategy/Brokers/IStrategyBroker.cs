using System.Collections.Immutable;

namespace ProviderConnector.Infrastructure.Strategies.GetBalanceStrategy.Brokers;

public interface IStrategyBroker
{
    ValueTask<ImmutableDictionary<int, string>> GetStrategies();
}