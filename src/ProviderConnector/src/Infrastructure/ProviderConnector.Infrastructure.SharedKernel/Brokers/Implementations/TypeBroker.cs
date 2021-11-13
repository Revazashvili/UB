namespace ProviderConnector.Infrastructure.Factories.Brokers.Implementations;
using System.Reflection;
using Core.Providers.Attributes;
using Interfaces;

public class TypeBroker : ITypeBroker
{
    public IEnumerable<Type> GetAllTypeWithProviderAttribute()
    {
        var assembly = Assembly.GetExecutingAssembly();
        foreach(var type in assembly.GetTypes())
            if (type.GetCustomAttributes(typeof(ProviderAttribute), true).Length > 0)
                yield return type;
    }
}