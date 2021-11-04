using System.Collections.Generic;
using System.Threading.Tasks;
using ProviderConnector.Core.Models.Common;

namespace ProviderConnector.Infrastructure.Strategies.GetBalanceStrategy.Factory
{
    public interface ICommonProviderFactory
    {
        ValueTask<Dictionary<int,ICommonProvider>> GetCommonProvidersAsync();
    }
}