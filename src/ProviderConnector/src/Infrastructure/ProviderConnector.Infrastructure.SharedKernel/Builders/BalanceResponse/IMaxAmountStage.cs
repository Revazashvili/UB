using ProviderConnector.Core.Models.Responses;

namespace ProviderConnector.Infrastructure.SharedKernel.Builders.BalanceResponse;

public interface IMaxAmountStage
{
    /// <summary>
    ///     Adds max pay amount to <see cref="GetBalanceResponse" /> instance.
    /// </summary>
    /// <param name="maxAmount">The min money amount.</param>
    IStatusStage WithMaxPayAmount(decimal maxAmount);

    /// <summary>
    ///     Set MaxPayAmount to null.
    /// </summary>
    IStatusStage WithoutMaxPayAmount();
}