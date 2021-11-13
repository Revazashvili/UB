using ProviderConnector.Core.Models.Responses;

namespace ProviderConnector.Infrastructure.Builders.BalanceResponseBuilder;

public interface IBalanceBuilderStage
{
    /// <summary>
    ///     Returns built <see cref="GetBalanceResponse" />.
    /// </summary>
    GetBalanceResponse Build();
}