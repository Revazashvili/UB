using ProviderConnector.Core.Models.Responses;

namespace ProviderConnector.Infrastructure.SharedKernel.Builders.PaymentResponse;

public interface IPaymentBuilder
{
    /// <summary>
    /// Returns built <see cref="PaymentResponse"/>.
    /// </summary>
    Core.Models.Responses.PaymentResponse Build();
}