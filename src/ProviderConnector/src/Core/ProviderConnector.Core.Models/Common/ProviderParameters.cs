namespace ProviderConnector.Core.Models.Common;

/// <summary>
/// Type for provider parameters
/// </summary>
public class ProviderParameters
{
    /// <summary>
    /// Initializes new instance of <see cref="ProviderParameters"/>.
    /// </summary>
    public ProviderParameters() => Parameters = new List<Parameter>();

    /// <summary>
    /// Get or sets <see cref="Parameter"/> list.
    /// </summary>
    public List<Parameter> Parameters { get; set; }
}