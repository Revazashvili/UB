using ProviderConnector.Core.Models.Common;
using ProviderConnector.Core.Models.Responses;

namespace ProviderConnector.Infrastructure.Builders.BalanceResponseBuilder;

public interface ISecondParameterStage
{
    /// <summary>
    ///     Adds parameter to <see cref="GetBalanceResponse" /> instance.
    /// </summary>
    /// <param name="value"><see cref="Parameter" /> value.</param>
    IThirdParameterStage WithSecondParameter(object value);

    /// <summary>
    ///     Specifies that <see cref="GetBalanceResponse" /> doesn't have second parameter.
    /// </summary>
    IAbonentInfoStage WithoutSecondParameter();
}