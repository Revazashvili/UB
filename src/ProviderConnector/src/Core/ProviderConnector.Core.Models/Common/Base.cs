using Forbids;

namespace ProviderConnector.Core.Models.Common;

/// <summary>
/// Base model for request and response.
/// </summary>
public class Base
{
    /// <summary>
    /// Gets or sets provider identifier.
    /// </summary>
    public int ProviderId { get; set; }
    
    /// <summary>
    /// Get or sets <see cref="Parameter"/> list.
    /// </summary>
    public List<Parameter> Parameters { get; set; }
    
    
    public string? this[string key]
    {
        get
        {
            Forbid.From.NullOrEmpty(key);
            return Parameters.FirstOrDefault(i => i.Key == key)?.Value;
        }
        set
        {
            Forbid.From.NullOrEmpty(key);
            Forbid.From.Null(value);
            var val = Parameters.FirstOrDefault(i => i.Key == key);
            if (val != null)
                val.Value = value!;
            else
                Parameters.Add(new Parameter(key, value));
        }
    }

    public bool HasParameterWithKey(string key) => Parameters.Any(i => i.Key == key);
}