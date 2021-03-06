using ProviderConnector.Core.Models.Responses;

namespace ProviderConnector.Infrastructure.Builders.BalanceResponseBuilder;

public interface IAmountStage
{
    /// <summary>
    ///     Adds amount to <see cref="GetBalanceResponse" /> instance.
    /// </summary>
    /// <param name="amount">The payed money amount.</param>
    IMinAmountStage WithAmount(decimal amount);
}