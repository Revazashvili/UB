using System.Reflection;
using ProviderConnector.Core.Providers.Attributes;

namespace ProviderConnector.Infrastructure.SharedKernel.Brokers;

/// <summary>
///     Broker interface for types.
/// </summary>
public interface ITypeProvider
{
    /// <summary>
    ///     Return all type with <see cref="ProviderAttribute" /> in executing assembly.
    /// </summary>
    /// <returns>
    ///     <see cref="IEnumerable{T}" />
    /// </returns>
    IEnumerable<Type> GetAllTypeWithProviderAttribute();
}

public class TypeProvider : ITypeProvider
{
    public IEnumerable<Type> GetAllTypeWithProviderAttribute()
    {
        var assembly = Assembly.GetExecutingAssembly();
        foreach (var type in assembly.GetTypes())
            if (type.GetCustomAttributes(typeof(ProviderAttribute), true).Length > 0)
                yield return type;
    }
}