using System;

namespace ProviderConnector.Core.Providers.Attributes;

/// <summary>
///     Attribute for provider metadata.
/// </summary>
[AttributeUsage(AttributeTargets.Class)]
public class ProviderAttribute : Attribute
{
    /// <summary>
    ///     Initializes new instance of <see cref="ProviderAttribute" />.
    /// </summary>
    /// <param name="providerId">The provider identifier.</param>
    public ProviderAttribute(int providerId)
    {
        ProviderId = providerId;
    }

    /// <summary>
    ///     Gets or sets provider identifier.
    /// </summary>
    public int ProviderId { get; set; }
}