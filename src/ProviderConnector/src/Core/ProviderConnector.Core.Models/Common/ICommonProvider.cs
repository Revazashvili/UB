using System.Threading.Tasks;
using ProviderConnector.Core.Models.Requests;
using ProviderConnector.Core.Models.Responses;

namespace ProviderConnector.Core.Models.Common
{
    public interface ICommonProvider : IProvider
    {
        ValueTask<Balance> GetBalanceAsync(GetBalanceRequest getBalanceRequest);
    }
}