namespace ProviderConnector.Infrastructure.Strategies.GetBalanceStrategy.Strategy;
using System.Threading.Tasks;
using Core.Models.Requests;
using Core.Models.Responses;


public interface IGetBalanceStrategy
{
    ValueTask<IEnumerable<GetBalanceResponse>> GetBalanceAsync(GetBalanceRequest getBalanceRequest);
}