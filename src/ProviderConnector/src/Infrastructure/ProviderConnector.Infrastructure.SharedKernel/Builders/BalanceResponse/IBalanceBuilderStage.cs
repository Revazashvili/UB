using ProviderConnector.Core.Models.Responses;

namespace ProviderConnector.Infrastructure.SharedKernel.Builders.BalanceResponse;

public interface IBalanceBuilderStage
{
    /// <summary>
    ///     Returns built <see cref="GetBalanceResponse" />.
    /// </summary>
    GetBalanceResponse Build();
}