using System.Collections.Generic;
using System.Threading.Tasks;
using ProviderConnector.Core.Models.Contracts;
using ProviderConnector.Core.Models.Requests;

namespace ProviderConnector.Core.Models.Common
{
    public interface IListProvider : IProvider
    {
        ValueTask<IEnumerable<Balance>> GetBalanceAsync(GetBalanceRequest getBalanceRequest);
    }
}