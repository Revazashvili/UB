namespace ProviderConnector.Core.Providers.Providers;
using Models.Common;
using Models.Enums;
using Models.Requests;
using Models.Responses;
using Attributes;
using Interfaces;

[Provider(1)]
public class FirstProvider : IProvider
{
    public ValueTask<IEnumerable<GetBalanceResponse>> GetBalanceAsync(GetBalanceRequest getBalanceRequest)
    {
        return new ValueTask<IEnumerable<GetBalanceResponse>>(new GetBalanceResponse[]
        {
            new GetBalanceResponse
            {
                ProviderId = 1,
                Amount = 1,
                AbonentInfo = "asdasd",
                Status = Status.Success,
                MaxPayAmount = 1,
                MinPayAmount = 1,
                Parameters = new List<Parameter>
                {
                    new Parameter("param1", "123213123")
                }
            }
        });
    }
}