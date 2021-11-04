using System.Collections.Generic;
using System.Threading.Tasks;
using ProviderConnector.Core.Models.Common;
using ProviderConnector.Core.Providers.FirstCategory;

namespace ProviderConnector.Infrastructure.Strategies.GetBalanceStrategy.Factory
{
    public class CommonProviderFactory : ICommonProviderFactory
    {
        public ValueTask<Dictionary<int, ICommonProvider>> GetCommonProvidersAsync()
        {
            var commonProviderKeyValuePair = new Dictionary<int, ICommonProvider>()
            {
                { 7016, new Telmico() }
            };
            return new ValueTask<Dictionary<int, ICommonProvider>>(commonProviderKeyValuePair);
        }
    }
}