using ProviderConnector.Infrastructure.Persistence.Models;

namespace ProviderConnector.Infrastructure.Persistence;

public class AppDbContext
{
    public List<ProviderConfiguration> ProviderConfigurations => new()
    {
        new() { Id = 1, ProviderId = 7016, Name = "Telmico", IsList = false },
        new() { Id = 2, ProviderId = 7017, Name = "Some", IsList = false },
    };
}