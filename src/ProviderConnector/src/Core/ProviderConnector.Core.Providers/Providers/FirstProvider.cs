using ProviderConnector.Core.Models.Enums;
using ProviderConnector.Core.Models.Requests;
using ProviderConnector.Core.Models.Responses;
using ProviderConnector.Core.Providers.Attributes;
using ProviderConnector.Core.Providers.Interfaces;
using ProviderConnector.Infrastructure.Builders.BalanceResponseBuilder;
using ProviderConnector.Infrastructure.Builders.PaymentResponseBuilder;

namespace ProviderConnector.Core.Providers.Providers;

[Provider(1)]
public class FirstProvider : IProvider
{
    public ValueTask<IEnumerable<GetBalanceResponse>> GetBalanceAsync(GetBalanceRequest getBalanceRequest)
    {
        var getBalanceResponse = BalanceResponseBuilder
            .Create()
            .WithProviderId(1)
            .WithFirstParameter("12345")
            .WithoutSecondParameter()
            .WithAbonentInfo("abonent info")
            .WithAmount(10)
            .WithoutMinPayAmount()
            .WithoutMaxPayAmount()
            .WithStatus(Status.Success)
            .WithoutAdditionalParameters()
            .Build();
        return new ValueTask<IEnumerable<GetBalanceResponse>>(new[] { getBalanceResponse });
    }

    public ValueTask<PaymentResponse> PayAsync(PaymentRequest paymentRequest)
    {
        var paymentResponse = PaymentResponseBuilder
            .Create().WithTransactionId(123456789)
            .WithStatus(PaymentStatus.SuccessOrDuplicateTransaction)
            .Build();
        return new ValueTask<PaymentResponse>(paymentResponse);
    }
}