using ProviderConnector.Core.Models.Responses;

namespace ProviderConnector.Infrastructure.Builders.BalanceResponseBuilder;

public interface IAbonentInfoStage
{
    /// <summary>
    ///     Adds abonent information to <see cref="GetBalanceResponse" /> instance.
    /// </summary>
    /// <param name="abonentInfo">The abonent information.</param>
    IAmountStage WithAbonentInfo(string abonentInfo);
}