namespace ProviderConnector.Core.Models.Common;
using Requests;
using Responses;

public interface IProvider
{
    ValueTask<IEnumerable<GetBalanceResponse>> GetBalanceAsync(GetBalanceRequest getBalanceRequest);
}