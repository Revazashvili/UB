using ProviderConnector.Infrastructure.Strategies.GetBalanceStrategy.Brokers;

namespace ProviderConnector.Infrastructure.Strategies.GetBalanceStrategy.Strategy;
using Forbids;
using Core.Models.Requests;
using Core.Models.Responses;
using Exceptions;
using Factory;

public class GetBalanceStrategy : IGetBalanceStrategy
{
    private readonly IProviderFactory _providerFactory;
    private readonly IStrategyBroker _strategyBroker;

    public GetBalanceStrategy(IProviderFactory providerFactory, IStrategyBroker strategyBroker) =>
        (_providerFactory, _strategyBroker) = (providerFactory, strategyBroker);

    public async ValueTask<IEnumerable<GetBalanceResponse>> GetBalanceAsync(GetBalanceRequest getBalanceRequest)
    {
        try
        {
            var providerStrategies =await _strategyBroker.GetStrategies();
            Forbid.From.NullOrEmpty(providerStrategies);
            var providerStrategy = providerStrategies[getBalanceRequest.ProviderId];
            Forbid.From.NullOrEmpty(providerStrategy);
            var provider = await _providerFactory.BuildProviderAsync(providerStrategy);
            Forbid.From.Null(provider, new ProviderNotFoundException());
            return await provider.GetBalanceAsync(getBalanceRequest);
        }
        catch (Exception exception)
        {
            //TODO:log exception
            return Enumerable.Empty<GetBalanceResponse>();
        }
    }
}