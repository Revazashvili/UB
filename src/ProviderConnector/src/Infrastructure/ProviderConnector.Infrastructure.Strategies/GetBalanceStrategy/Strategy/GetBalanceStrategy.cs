using System;
using System.Threading.Tasks;
using ProviderConnector.Core.Models.Contracts;
using ProviderConnector.Core.Models.Requests;
using ProviderConnector.Infrastructure.Strategies.GetBalanceStrategy.Factory;

namespace ProviderConnector.Infrastructure.Strategies.GetBalanceStrategy.Strategy
{
    public class GetBalanceStrategy : IGetBalanceStrategy
    {
        private readonly ICommonProviderFactory _commonProviderFactory;

        public GetBalanceStrategy(ICommonProviderFactory commonProviderFactory)
        {
            _commonProviderFactory = commonProviderFactory;
        }

        public async ValueTask<Balance> GetBalanceAsync(GetBalanceRequest getBalanceRequest)
        {
            var providers = await _commonProviderFactory.GetCommonProvidersAsync();
            var provider = providers[getBalanceRequest.ProviderId];
            if (provider == null)
                throw new ArgumentNullException("No Provider Can't be found with provided id.");
            return await provider.GetBalanceAsync(getBalanceRequest);
        }
    }
}