namespace ProviderConnector.Infrastructure.Persistence.Models;

public class ProviderConfiguration
{
    public int Id { get; set; }
    public int ProviderId { get; set; }
    public string Name { get; set; }
    public bool IsList { get; set; }
}