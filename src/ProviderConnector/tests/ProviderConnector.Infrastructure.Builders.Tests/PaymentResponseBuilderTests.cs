using ProviderConnector.Core.Models.Enums;
using ProviderConnector.Infrastructure.Builders.PaymentResponseBuilder;
using Xunit;

namespace ProviderConnector.Infrastructure.Builders.Tests;

public class PaymentResponseBuilderTests
{
    [Fact]
    public void Some()
    {
        PaymentResponseBuilder.PaymentResponseBuilder
            .Create()
            .WithTransactionId(1)
            .WithStatus(PaymentStatus.SuccessOrDuplicateTransaction)
            .Build();
    }
}