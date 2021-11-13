using Forbids;
using ProviderConnector.Core.Models.Enums;

namespace ProviderConnector.Infrastructure.Builders.PaymentResponseBuilder;

public class PaymentResponseBuilder : ITransactionIdStage, IStatusStage, IPaymentBuilderStage
{
    private readonly Core.Models.Responses.PaymentResponse _paymentResponse;

    private PaymentResponseBuilder()
    {
        _paymentResponse = new Core.Models.Responses.PaymentResponse();
    }

    public Core.Models.Responses.PaymentResponse Build()
    {
        return _paymentResponse;
    }

    public IPaymentBuilderStage WithStatus(PaymentStatus status)
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

    public IStatusStage WithTransactionId(long transactionId)
    {
        _paymentResponse.TransactionId = Forbid.From.Zero(transactionId);
        return this;
    }

    public static ITransactionIdStage Create()
    {
        return new PaymentResponseBuilder();
    }
}