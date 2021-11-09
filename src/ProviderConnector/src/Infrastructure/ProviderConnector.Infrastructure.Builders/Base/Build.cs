namespace ProviderConnector.Infrastructure.Builders.Base;
using Responses;

public class Build : IBuilder
{
    public static GetBalanceResponseBuilder Balance { get; } = new();
    public static PaymentResponseBuilder Payment { get; } = new();
}