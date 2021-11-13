using ProviderConnector.Core.Models.Common;
using ProviderConnector.Core.Models.Enums;
using ProviderConnector.Core.Models.Requests;
using ProviderConnector.Core.Models.Responses;
using ProviderConnector.Core.Providers.Attributes;
using ProviderConnector.Core.Providers.Interfaces;

namespace ProviderConnector.Core.Providers.Providers;

[Provider(1)]
public class FirstProvider : IProvider
{
    public ValueTask<IEnumerable<GetBalanceResponse>> GetBalanceAsync(GetBalanceRequest getBalanceRequest)
    {
        return new ValueTask<IEnumerable<GetBalanceResponse>>(new[]
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
                    new("param1", "123213123")
                }
            }
        });
    }

    public ValueTask<PaymentResponse> PayAsync(PaymentRequest paymentRequest)
    {
        return new ValueTask<PaymentResponse>(new PaymentResponse());
    }
}