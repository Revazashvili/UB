using ProviderConnector.Infrastructure.SharedKernel.Builders.ResponseBuilder.Responses;

namespace ProviderConnector.Infrastructure.SharedKernel.Builders.ResponseBuilder;

public class Build
{
    public static GetBalanceResponseBuilder Balance { get; } = new();
    public static PaymentResponseBuilder Payment { get; } = new();
}