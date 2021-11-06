using ProviderConnector.Infrastructure.Builders.Base;
using Xunit;

namespace ProviderConnector.Infrastructure.Builders.Tests;

public class PaymentRequestBuilderTests
{
    [Fact]
    public void CorrectlyConstructs()
    {
        
        var request = Build.PaymentRequest
            .WithPaymentId(12345)
            .WithPayingAmount(10)
            .WithOperationDate(DateTime.Today)
            .WithFinalizeTime(DateTime.Today)
            .WithCurrentBalance(10)
            .WithAdditionalInfo("additionalinfo")
            .Build();
        Assert.Equal(12345,request.PaymentId);
    }
}