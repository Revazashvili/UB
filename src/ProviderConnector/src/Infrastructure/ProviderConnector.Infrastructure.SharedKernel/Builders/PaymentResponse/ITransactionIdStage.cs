using ProviderConnector.Core.Models.Responses;

namespace ProviderConnector.Infrastructure.SharedKernel.Builders.PaymentResponse;

public interface ITransactionIdStage
{
    /// <summary>
    /// Add transaction identifier to <see cref="PaymentResponse"/> instance.
    /// </summary>
    /// <param name="transactionId">The transaction identifier.s</param>
    IStatusStage WithTransactionId(long transactionId);
}