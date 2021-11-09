using ProviderConnector.Core.Providers.Attributes;

namespace ProviderConnector.Infrastructure.Factories.Brokers.Interfaces;

/// <summary>
/// Broker interface for types.
/// </summary>
public interface ITypeBroker
{ 
    /// <summary>
    /// Return all type with <see cref="ProviderAttribute"/> in executing assembly.
    /// </summary>
    /// <returns><see cref="IEnumerable{T}"/></returns>
    IEnumerable<Type> GetAllTypeWithProviderAttribute();
}