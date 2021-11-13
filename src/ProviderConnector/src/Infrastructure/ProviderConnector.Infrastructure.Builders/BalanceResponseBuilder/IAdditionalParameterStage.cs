using ProviderConnector.Core.Models.Common;
using ProviderConnector.Core.Models.Responses;

namespace ProviderConnector.Infrastructure.Builders.BalanceResponseBuilder;

public interface IAdditionalParameterStage
{
    /// <summary>
    ///     Adds parameters to <see cref="GetBalanceResponse" /> instance.
    /// </summary>
    /// <param name="additionalParameters"><see cref="Parameter" /> array.</param>
    IBalanceBuilderStage WithAdditionalParameters(params Parameter[] additionalParameters);

    /// <summary>
    ///     Specifies that <see cref="GetBalanceResponse" /> doesn't have additional parameters.
    /// </summary>
    IBalanceBuilderStage WithoutAdditionalParameters();
}