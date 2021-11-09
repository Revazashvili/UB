using ProviderConnector.Core.Models.Enums;

namespace ProviderConnector.Core.Models.Responses;

public class PaymentResponse
{
    public long TransactionId { get; set; }
    public PaymentStatus Status { get; set; }
}