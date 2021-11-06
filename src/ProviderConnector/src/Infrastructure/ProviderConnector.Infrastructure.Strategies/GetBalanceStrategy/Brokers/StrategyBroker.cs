using System.Collections.Immutable;
using ProviderConnector.Infrastructure.Persistence;

namespace ProviderConnector.Infrastructure.Strategies.GetBalanceStrategy.Brokers;

public class StrategyBroker : IStrategyBroker
{
    private readonly AppDbContext _dbContext;

    public StrategyBroker(AppDbContext dbContext) => _dbContext = dbContext;

    public ValueTask<ImmutableDictionary<int, string>> GetStrategies() =>
        new(_dbContext.ProviderConfigurations.ToImmutableDictionary(configuration => configuration.ProviderId,
            configuration => configuration.Name));
}