namespace ProviderConnector.Core.Models.Requests;

using Common;

/// <summary>
/// Base request model
/// </summary>
public class Request : ProviderParameters
{
    /// <summary>
    /// Gets or sets provider identifier.
    /// </summary>
    public int ProviderId { get; set; }
}