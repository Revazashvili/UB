using ProviderConnector.Core.Models.Responses;

namespace ProviderConnector.Infrastructure.Builders.BalanceResponseBuilder;

public interface IProviderIdStage
{
    /// <summary>
    ///     Adds provider id to <see cref="GetBalanceResponse" /> instance.
    /// </summary>
    /// <param name="providerId">Provider identifier.</param>
    IFirstParameterStage WithProviderId(int providerId);
}