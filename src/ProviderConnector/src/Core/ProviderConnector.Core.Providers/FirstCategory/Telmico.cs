using ProviderConnector.Core.Models.Responses;

namespace ProviderConnector.Core.Providers.FirstCategory;
using System.Collections.Generic;
using System.Threading.Tasks;
using Models.Common;
using Models.Requests;

public class Telmico : IProvider
{
    public ValueTask<IEnumerable<GetBalanceResponse>> GetBalanceAsync(GetBalanceRequest getBalanceRequest)
    {
        return new ValueTask<IEnumerable<GetBalanceResponse>>(new[]
        {
            new GetBalanceResponse
            {
                AbonentInfo = "abonent",
                Amount = 10,
                ProviderId = 7016,
                Parameters = new List<Parameter>
                {
                    new("param1", "891361923")
                }
            }
        });
    }
}