using System.Collections.Generic;
using System.Threading.Tasks;
using ProviderConnector.Core.Models.Requests;
using ProviderConnector.Core.Models.Responses;

namespace ProviderConnector.Core.Models.Common
{
    public interface IListProvider : IProvider
    {
        ValueTask<IEnumerable<Balance>> GetBalanceAsync(GetBalanceRequest getBalanceRequest);
    }
}