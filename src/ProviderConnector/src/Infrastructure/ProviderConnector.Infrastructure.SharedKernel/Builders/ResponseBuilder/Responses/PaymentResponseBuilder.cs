using Forbids;
using ProviderConnector.Core.Models.Enums;
using ProviderConnector.Core.Models.Responses;

namespace ProviderConnector.Infrastructure.SharedKernel.Builders.ResponseBuilder.Responses;

/// <summary>
/// Builder class for <see cref="PaymentResponse"/>.
/// </summary>
public class PaymentResponseBuilder
{
    /// <summary>
    /// Instance of <see cref="PaymentResponse"/> class.
    /// </summary>
    private PaymentResponse _paymentResponse = new();

    /// <summary>
    /// Add transaction identifier to <see cref="PaymentResponse"/> instance.
    /// </summary>
    /// <param name="transactionId">The transaction identifier.s</param>
    /// <returns>Reference to <see cref="PaymentResponseBuilder"/> object.</returns>
    public PaymentResponseBuilder WithTransactionId(long transactionId)
    {
        Forbid.From.Zero(transactionId);
        _paymentResponse.TransactionId = transactionId;
        return this;
    }
    
    /// <summary>
    /// Add status to <see cref="PaymentResponse"/> instance.
    /// </summary>
    /// <param name="status"><see cref="PaymentStatus"/></param>
    /// <returns>Reference to <see cref="PaymentResponseBuilder"/> object.</returns>
    public PaymentResponseBuilder WithStatus(PaymentStatus status)
    {
        _paymentResponse.Status = status;
        return this;
    }

    /// <summary>
    /// add Error status and default transaction identifier <see cref="PaymentResponse"/> instance.
    /// </summary>
    /// <returns>Reference to <see cref="PaymentResponseBuilder"/> object.</returns>
    public PaymentResponseBuilder Failed()
    {
        _paymentResponse.Status = PaymentStatus.UndefinedError;
        _paymentResponse.TransactionId = default;
        return this;
    }
    
    /// <summary>
    /// add passed status and default transaction identifier <see cref="PaymentResponse"/> instance.
    /// </summary>
    /// <param name="status"><see cref="PaymentStatus"/></param>
    /// <returns>Reference to <see cref="PaymentResponseBuilder"/> object.</returns>
    public PaymentResponseBuilder FailedWithStatus(PaymentStatus status)
    {
        _paymentResponse.Status = status;
        _paymentResponse.TransactionId = default;
        return this;
    }

    /// <summary>
    /// Returns built <see cref="PaymentResponse"/>.
    /// </summary>
    /// <returns><see cref="PaymentResponse"/> instance.</returns>
    public PaymentResponse Build() => _paymentResponse;
}