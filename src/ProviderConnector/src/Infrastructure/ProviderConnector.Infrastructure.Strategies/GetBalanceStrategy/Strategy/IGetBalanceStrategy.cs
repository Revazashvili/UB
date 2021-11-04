using System.Threading.Tasks;
using ProviderConnector.Core.Models.Contracts;
using ProviderConnector.Core.Models.Requests;

namespace ProviderConnector.Infrastructure.Strategies.GetBalanceStrategy.Strategy
{
    public interface IGetBalanceStrategy
    {
        ValueTask<Balance> GetBalanceAsync(GetBalanceRequest getBalanceRequest);
    }
}