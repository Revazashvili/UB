using System.Collections.Generic;
using ProviderConnector.Core.Models.Contracts;

namespace ProviderConnector.Core.Models.Requests
{
    public class GetBalanceRequest
    {
        public GetBalanceRequest() => Parameters = new List<Parameter>();

        public int ProviderId { get; set; }
        public List<Parameter> Parameters { get; set; }
    }
}