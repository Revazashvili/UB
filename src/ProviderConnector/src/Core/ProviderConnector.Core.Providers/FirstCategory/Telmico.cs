using System.Collections.Generic;
using System.Threading.Tasks;
using ProviderConnector.Core.Models.Common;
using ProviderConnector.Core.Models.Requests;
using ProviderConnector.Core.Models.Responses;

namespace ProviderConnector.Core.Providers.FirstCategory
{
    public class Telmico : ICommonProvider
    {
        public ValueTask<Balance> GetBalanceAsync(GetBalanceRequest getBalanceRequest)
        {
            return new ValueTask<Balance>(new Balance
            {
                Abonent = "abonent",
                Amount = 10,
                ProviderId = 7016,
                Parameters = new List<Parameter>
                {
                    new("param1", "891361923")
                }
            });
        }
    }
}