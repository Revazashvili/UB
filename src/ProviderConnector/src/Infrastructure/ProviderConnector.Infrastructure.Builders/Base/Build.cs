using ProviderConnector.Infrastructure.Builders.Requests;

namespace ProviderConnector.Infrastructure.Builders.Base;

public class Build : IBuilder
{
    public static GetBalanceRequestBuilder BalanceRequest { get; } = new();
    public static PaymentRequestBuilder PaymentRequest { get; } = new();
}