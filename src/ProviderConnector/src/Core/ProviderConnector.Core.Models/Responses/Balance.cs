namespace ProviderConnector.Core.Models.Responses;
using Common;


public class Balance
{
    public Balance()
    {
        Parameters = new List<Parameter>();
    }

    public Balance(int providerId, int amount, string abonent, List<Parameter> parameters)
    {
        ProviderId = providerId;
        Amount = amount;
        Abonent = abonent;
        Parameters = parameters;
    }
        
    public Balance(int providerId, int amount, string abonent)
    {
        ProviderId = providerId;
        Amount = amount;
        Abonent = abonent;
        Parameters = new List<Parameter>();
    }

    public int ProviderId { get; set; }
    public int Amount { get; set; }
    public string Abonent { get; set; }
    public List<Parameter> Parameters { get; set; }
}