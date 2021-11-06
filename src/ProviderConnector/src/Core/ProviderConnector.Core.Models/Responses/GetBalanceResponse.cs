namespace ProviderConnector.Core.Models.Responses;

public class GetBalanceResponse : Response
{
    public decimal Amount { get; set; }
    public decimal MinPayAmount { get; set; }
    public decimal MaxPayAmount { get; set; }
    public string AbonentInfo { get; set; } = null!;
}