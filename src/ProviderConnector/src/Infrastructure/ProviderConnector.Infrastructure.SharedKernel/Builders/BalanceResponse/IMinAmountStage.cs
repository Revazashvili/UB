using ProviderConnector.Core.Models.Responses;

namespace ProviderConnector.Infrastructure.SharedKernel.Builders.BalanceResponse;

public interface IMinAmountStage
{
    /// <summary>
    ///     Adds min pay amount to <see cref="GetBalanceResponse" /> instance.
    /// </summary>
    /// <param name="minAmount">The min money amount.</param>
    IMaxAmountStage WithMinPayAmount(decimal minAmount);

    /// <summary>
    ///     Set MinPayAmount to null.
    /// </summary>
    IMaxAmountStage WithoutMinPayAmount();
}