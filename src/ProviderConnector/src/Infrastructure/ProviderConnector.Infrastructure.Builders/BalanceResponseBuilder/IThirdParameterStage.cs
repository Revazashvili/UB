using ProviderConnector.Core.Models.Common;
using ProviderConnector.Core.Models.Responses;

namespace ProviderConnector.Infrastructure.Builders.BalanceResponseBuilder;

public interface IThirdParameterStage
{
    /// <summary>
    ///     Adds parameter to <see cref="GetBalanceResponse" /> instance.
    /// </summary>
    /// <param name="value"><see cref="Parameter" /> value.</param>
    IParameterStage WithThirdParameter(object value);
}