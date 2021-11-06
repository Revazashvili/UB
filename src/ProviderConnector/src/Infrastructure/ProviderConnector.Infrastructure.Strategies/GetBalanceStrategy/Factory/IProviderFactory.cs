using System.Collections.Generic;
using System.Threading.Tasks;
using ProviderConnector.Core.Models.Common;

namespace ProviderConnector.Infrastructure.Strategies.GetBalanceStrategy.Factory
{
    public interface IProviderFactory
    {
        ValueTask<Dictionary<int,IProvider>> GetCommonProvidersAsync();
    }
}