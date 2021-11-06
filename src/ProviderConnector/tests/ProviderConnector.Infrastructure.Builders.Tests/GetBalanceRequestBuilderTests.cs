using ProviderConnector.Core.Models.Common;
using ProviderConnector.Infrastructure.Builders.Base;
using ProviderConnector.Infrastructure.Builders.Exceptions;
using Xunit;

namespace ProviderConnector.Infrastructure.Builders.Tests;

public class GetBalanceRequestBuilderTests
{
    [Fact]
    public void CorrectlyConstructs()
    {
        var request = Build.BalanceRequest
            .WithProviderId(70)
            .WithFirstParameter("first")
            .WithSecondParameter("second")
            .WithThirdParameter("third")
            .Build();
        Assert.NotNull(request);
        Assert.Equal(70, request.ProviderId);
        Assert.Equal("first", request.Parameters.FirstOrDefault(x=>x.Key == "param1").Value);
        Assert.Equal("second", request.Parameters.FirstOrDefault(x=>x.Key == "param2").Value);
        Assert.Equal("third", request.Parameters.FirstOrDefault(x=>x.Key == "param3").Value);
    }

    [Fact]
    public void ThrowsExceptionWhenAppendZeroProviderId()
    {
        Assert.Throws<ArgumentException>(() => Build.BalanceRequest
            .WithProviderId(0));
    }

    [Fact]
    public void ThrowsExceptionWhenAddTwoSameParameter()
    {
        Assert.Throws<ParameterAlreadyExistsException>(() =>
            Build.BalanceRequest.WithFirstParameter("sd").WithFirstParameter("s"));
        Assert.Throws<ParameterAlreadyExistsException>(() =>
            Build.BalanceRequest.WithSecondParameter("sd").WithSecondParameter("s"));
        Assert.Throws<ParameterAlreadyExistsException>(() =>
            Build.BalanceRequest.WithThirdParameter("sd").WithThirdParameter("s"));
        Assert.Throws<ParameterAlreadyExistsException>(() =>
            Build.BalanceRequest.WithParameter(new Parameter("param1", "sdad"))
                .WithParameter(new Parameter("param1", "sdad")));
    }
    
    [Fact]
    public void ThrowsExceptionWhenPassedParameterIsNull()
    {
        Assert.Throws<ParameterNullException>(() =>
            Build.BalanceRequest.WithFirstParameter(null));
        Assert.Throws<ParameterNullException>(() =>
            Build.BalanceRequest.WithSecondParameter(null));
        Assert.Throws<ParameterNullException>(() =>
            Build.BalanceRequest.WithThirdParameter(null));
        Assert.Throws<ParameterNullException>(() =>
            Build.BalanceRequest.WithParameter(null));
    }
}