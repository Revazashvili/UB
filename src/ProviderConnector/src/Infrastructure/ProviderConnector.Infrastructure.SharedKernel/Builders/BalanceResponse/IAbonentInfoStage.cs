using ProviderConnector.Core.Models.Responses;

namespace ProviderConnector.Infrastructure.SharedKernel.Builders.BalanceResponse;

public interface IAbonentInfoStage
{
    /// <summary>
    ///     Adds abonent information to <see cref="GetBalanceResponse" /> instance.
    /// </summary>
    /// <param name="abonentInfo">The abonent information.</param>
    IAmountStage WithAbonentInfo(string abonentInfo);
}