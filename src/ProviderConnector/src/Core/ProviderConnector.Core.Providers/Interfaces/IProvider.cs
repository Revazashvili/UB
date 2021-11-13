using ProviderConnector.Core.Models.Requests;
using ProviderConnector.Core.Models.Responses;

namespace ProviderConnector.Core.Providers.Interfaces;

/// <summary>
///     Abstraction for provider.
/// </summary>
public interface IProvider
{
    /// <summary>
    ///     Returns list of balance responses.
    /// </summary>
    /// <param name="getBalanceRequest"><see cref="GetBalanceRequest" />.</param>
    /// <returns></returns>
    ValueTask<IEnumerable<GetBalanceResponse>> GetBalanceAsync(GetBalanceRequest getBalanceRequest);
}