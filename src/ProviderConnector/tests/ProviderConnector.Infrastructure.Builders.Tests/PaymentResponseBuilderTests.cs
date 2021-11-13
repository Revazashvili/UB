using ProviderConnector.Core.Models.Enums;
using ProviderConnector.Infrastructure.SharedKernel.Builders.PaymentResponse;
using Xunit;

namespace ProviderConnector.Infrastructure.Builders.Tests;

public class PaymentResponseBuilderTests
{
    [Fact]
    public void Some()
    {
        PaymentResponseBuilder
            .Create()
            .WithTransactionId(1)
            .WithStatus(PaymentStatus.SuccessOrDuplicateTransaction)
            .Build();
    }
}