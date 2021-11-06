using Forbids;
using ProviderConnector.Core.Models.Requests;

namespace ProviderConnector.Infrastructure.Builders.Requests;

/// <summary>
/// Builder class to build <see cref="PaymentRequest"/> step by step.
/// </summary>
public class PaymentRequestBuilder
{
    /// <summary>
    /// Instance of <see cref="PaymentRequest"/> class.
    /// </summary>
    private PaymentRequest _paymentRequest = new();
    
    /// <summary>
    /// Adds payment identifier to <see cref="PaymentRequest"/> instance.
    /// </summary>
    /// <param name="paymentId">Payment identifier.</param>
    /// <returns>Reference to <see cref="PaymentRequestBuilder"/> object.</returns>
    public PaymentRequestBuilder WithPaymentId(int paymentId)
    {
        _paymentRequest.PaymentId = Forbid.From.Zero(paymentId);
        return this;
    }
    
    /// <summary>
    /// Adds operation date to <see cref="PaymentRequest"/> instance.
    /// </summary>
    /// <param name="operationDate">Payment timestamp.</param>
    /// <returns>Reference to <see cref="PaymentRequestBuilder"/> object.</returns>
    public PaymentRequestBuilder WithOperationDate(DateTime operationDate)
    {
        Forbid.From.Equal(operationDate, DateTime.MaxValue);
        Forbid.From.Equal(operationDate, DateTime.MinValue);
        _paymentRequest.OperationDate = operationDate;
        return this;
    }
    
    /// <summary>
    /// Adds payed amount to <see cref="PaymentRequest"/> instance.
    /// </summary>
    /// <param name="payingAmount">Payed money.</param>
    /// <returns>Reference to <see cref="PaymentRequestBuilder"/> object.</returns>
    public PaymentRequestBuilder WithPayingAmount(decimal payingAmount)
    {
        _paymentRequest.PayingAmount = Forbid.From.NegativeOrZero(payingAmount);
        return this;
    }
    
    /// <summary>
    /// Adds current balance to <see cref="PaymentRequest"/> instance.
    /// </summary>
    /// <param name="currentBalance">Current balance.</param>
    /// <returns>Reference to <see cref="PaymentRequestBuilder"/> object.</returns>
    public PaymentRequestBuilder WithCurrentBalance(decimal currentBalance)
    {
        _paymentRequest.CurrentBalance = Forbid.From.NegativeOrZero(currentBalance);
        return this;
    }
    
    /// <summary>
    /// Adds payment finalize time to <see cref="PaymentRequest"/> instance.
    /// </summary>
    /// <param name="finalizeTime">Finalize time.</param>
    /// <returns>Reference to <see cref="PaymentRequestBuilder"/> object.</returns>
    public PaymentRequestBuilder WithFinalizeTime(DateTime finalizeTime)
    {
        Forbid.From.Equal(finalizeTime, DateTime.MaxValue);
        Forbid.From.Equal(finalizeTime, DateTime.MinValue);
        _paymentRequest.FinalizeTime = finalizeTime;
        return this;
    }
    
    /// <summary>
    /// Adds additional information to <see cref="PaymentRequest"/> instance.
    /// </summary>
    /// <param name="additionalInfo">Additional Information.</param>
    /// <returns>Reference to <see cref="PaymentRequestBuilder"/> object.</returns>
    public PaymentRequestBuilder WithAdditionalInfo(string additionalInfo)
    {
        _paymentRequest.AdditionalInfo = Forbid.From.NullOrEmpty(additionalInfo);
        return this;
    }

    /// <summary>
    /// Returns built <see cref="PaymentRequest"/>.
    /// </summary>
    /// <returns><see cref="PaymentRequest"/> instance.</returns>
    public PaymentRequest Build() => _paymentRequest;
}