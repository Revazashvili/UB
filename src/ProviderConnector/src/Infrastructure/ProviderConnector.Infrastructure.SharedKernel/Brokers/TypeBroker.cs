using System.Reflection;
using ProviderConnector.Core.Providers.Attributes;

namespace ProviderConnector.Infrastructure.SharedKernel.Brokers;

public interface ITypeProvider
{
    IEnumerable<Type> GetAllTypeWithProviderAttribute();
}

public class TypeProvider : ITypeProvider
{
    public IEnumerable<Type> GetAllTypeWithProviderAttribute() =>
        Assembly.GetExecutingAssembly().GetTypes()
            .Where(type => type.GetCustomAttributes(typeof(ProviderAttribute), true).Length > 0)
            .AsEnumerable();
}