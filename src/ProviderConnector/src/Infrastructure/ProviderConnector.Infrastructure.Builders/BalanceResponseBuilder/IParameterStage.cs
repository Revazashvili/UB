using ProviderConnector.Core.Models.Common;
using ProviderConnector.Core.Models.Responses;

namespace ProviderConnector.Infrastructure.Builders.BalanceResponseBuilder;

public interface IParameterStage
{
    /// <summary>
    ///     Adds parameters to <see cref="GetBalanceResponse" /> instance.
    /// </summary>
    /// <param name="parameters"><see cref="Parameter" /> array.</param>
    IAbonentInfoStage WithParameters(params Parameter[] parameters);
}