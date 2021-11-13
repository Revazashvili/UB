using Forbids;
using ProviderConnector.Core.Models.Enums;

namespace ProviderConnector.Infrastructure.SharedKernel.Builders.PaymentResponse;

public class PaymentResponseBuilderStage : ITransactionIdStage,IStatusStage,IPaymentBuilderStage
{
    private Core.Models.Responses.PaymentResponse _paymentResponse;
    private PaymentResponseBuilderStage() => _paymentResponse = new();

    public static ITransactionIdStage Create() => new PaymentResponseBuilderStage();

    public IStatusStage WithTransactionId(long transactionId)
    {
        _paymentResponse.TransactionId = Forbid.From.Zero(transactionId);
        return this;
    }
    
    public IPaymentBuilderStage WithStatus(PaymentStatus status)
    {
        _paymentResponse.Status = status;
        return this;
    }
    
    public PaymentResponseBuilderStage Failed()
    {
        _paymentResponse.Status = PaymentStatus.UndefinedError;
        _paymentResponse.TransactionId = 0;
        return this;
    }
    
    public Core.Models.Responses.PaymentResponse Build() => _paymentResponse;
}