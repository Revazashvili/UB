namespace ProviderConnector.Infrastructure.Strategies.GetBalanceStrategy.Strategy;
using Forbids;
using Core.Models.Requests;
using Core.Models.Responses;
using Exceptions;
using Factory;

public class GetBalanceStrategy : IGetBalanceStrategy
{
    private readonly IProviderFactory _providerFactory;

    public GetBalanceStrategy(IProviderFactory providerFactory) => _providerFactory = providerFactory;

    public async ValueTask<IEnumerable<GetBalanceResponse>> GetBalanceAsync(GetBalanceRequest getBalanceRequest)
    {
        try
        {
            var providers = await _providerFactory.GetCommonProvidersAsync();
            var provider = providers[getBalanceRequest.ProviderId];
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