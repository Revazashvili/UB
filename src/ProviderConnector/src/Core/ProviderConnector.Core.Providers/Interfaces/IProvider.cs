namespace ProviderConnector.Core.Providers.Interfaces;
using Models.Requests;
using Models.Responses;

/// <summary>
/// Abstraction for provider.
/// </summary>
public interface IProvider
{
    /// <summary>
    /// Returns list of balance responses.
    /// </summary>
    /// <param name="getBalanceRequest"><see cref="GetBalanceRequest"/>.</param>
    /// <returns></returns>
    ValueTask<IEnumerable<GetBalanceResponse>> GetBalanceAsync(GetBalanceRequest getBalanceRequest);
}