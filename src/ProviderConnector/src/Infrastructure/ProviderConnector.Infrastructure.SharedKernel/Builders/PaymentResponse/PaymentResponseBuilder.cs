using Forbids;
using ProviderConnector.Core.Models.Enums;

namespace ProviderConnector.Infrastructure.SharedKernel.Builders.PaymentResponse;

public class PaymentResponseBuilder : ITransactionIdStage,IStatusStage,IPaymentBuilder
{
    private Core.Models.Responses.PaymentResponse _paymentResponse;
    private PaymentResponseBuilder() => _paymentResponse = new();

    public static ITransactionIdStage Create() => new PaymentResponseBuilder();

    public IStatusStage WithTransactionId(long transactionId)
    {
        _paymentResponse.TransactionId = Forbid.From.Zero(transactionId);
        return this;
    }
    
    public IPaymentBuilder WithStatus(PaymentStatus status)
    {
        _paymentResponse.Status = status;
        return this;
    }
    
    public PaymentResponseBuilder Failed()
    {
        _paymentResponse.Status = PaymentStatus.UndefinedError;
        _paymentResponse.TransactionId = 0;
        return this;
    }
    
    public Core.Models.Responses.PaymentResponse Build() => _paymentResponse;
}