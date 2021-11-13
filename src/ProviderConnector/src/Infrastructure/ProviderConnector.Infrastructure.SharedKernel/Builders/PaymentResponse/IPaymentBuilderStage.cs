using ProviderConnector.Core.Models.Responses;

namespace ProviderConnector.Infrastructure.SharedKernel.Builders.PaymentResponse;

public interface IPaymentBuilderStage
{
    /// <summary>
    /// Returns built <see cref="PaymentResponse"/>.
    /// </summary>
    Core.Models.Responses.PaymentResponse Build();
}