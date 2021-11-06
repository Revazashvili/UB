using System.Threading.Tasks;
using ProviderConnector.Core.Models.Requests;
using ProviderConnector.Core.Models.Responses;

namespace ProviderConnector.Infrastructure.Strategies.GetBalanceStrategy.Strategy
{
    public interface IGetBalanceStrategy
    {
        ValueTask<Balance> GetBalanceAsync(GetBalanceRequest getBalanceRequest);
    }
}