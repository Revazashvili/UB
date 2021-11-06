namespace ProviderConnector.Core.Models.Common;

/// <summary>
/// Key-Value type provider provider parameters.
/// </summary>
public class Parameter
{
    /// <summary>
    /// Initializes new instance of <see cref="Parameter"/>.
    /// </summary>
    /// <param name="key">Parameter key.</param>
    /// <param name="value">Parameter value.</param>
    public Parameter(string key, string? value) => (Key, Value) = (key, value);

    /// <summary>
    /// Gets or sets parameter Key(name).
    /// </summary>
    public string Key { get; set; }
    /// <summary>
    /// Gets or sets parameter.
    /// </summary>
    public string Value { get; set; }
}