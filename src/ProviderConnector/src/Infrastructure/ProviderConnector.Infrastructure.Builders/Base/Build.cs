using ProviderConnector.Infrastructure.Builders.Requests;

namespace ProviderConnector.Infrastructure.Builders.Base;

public class Build : IBuilder
{
    public static GetBalanceRequestBuilder BalanceRequest { get; set; } = new();
}