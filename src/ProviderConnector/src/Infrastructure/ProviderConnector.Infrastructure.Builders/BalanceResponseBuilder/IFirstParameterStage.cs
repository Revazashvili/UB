using ProviderConnector.Core.Models.Common;
using ProviderConnector.Core.Models.Responses;

namespace ProviderConnector.Infrastructure.Builders.BalanceResponseBuilder;

public interface IFirstParameterStage
{
    /// <summary>
    ///     Adds parameter to <see cref="GetBalanceResponse" /> instance.
    /// </summary>
    /// <param name="value"><see cref="Parameter" /> value.</param>
    ISecondParameterStage WithFirstParameter(object value);
}