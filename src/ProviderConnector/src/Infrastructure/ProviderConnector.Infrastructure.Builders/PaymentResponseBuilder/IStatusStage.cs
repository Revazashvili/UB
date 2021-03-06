using ProviderConnector.Core.Models.Enums;
using ProviderConnector.Core.Models.Responses;

namespace ProviderConnector.Infrastructure.Builders.PaymentResponseBuilder;

public interface IStatusStage
{
    /// <summary>
    ///     Add status to <see cref="PaymentResponse" /> instance.
    /// </summary>
    /// <param name="status">
    ///     <see cref="PaymentStatus" />
    /// </param>
    IPaymentBuilderStage WithStatus(PaymentStatus status);

    /// <summary>
    ///     add Error status to <see cref="PaymentResponse" /> instance
    ///     and set transaction identifier to zero.
    /// </summary>
    PaymentResponseBuilder Failed();
}