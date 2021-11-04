using System.Threading.Tasks;
using ProviderConnector.Core.Models.Contracts;
using ProviderConnector.Core.Models.Requests;

namespace ProviderConnector.Core.Models.Common
{
    public interface ICommonProvider : IProvider
    {
        ValueTask<Balance> GetBalanceAsync(GetBalanceRequest getBalanceRequest);
    }
}