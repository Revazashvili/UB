using Forbids;
using ProviderConnector.Core.Models.Common;
using ProviderConnector.Core.Models.Enums;
using ProviderConnector.Core.Models.Responses;
using ProviderConnector.Infrastructure.Builders.BalanceResponseBuilder.Exceptions;

namespace ProviderConnector.Infrastructure.Builders.BalanceResponseBuilder;

public class BalanceResponseBuilder : IProviderIdStage,
    IFirstParameterStage,
    ISecondParameterStage,
    IThirdParameterStage,
    IParameterStage,
    IAbonentInfoStage,
    IAmountStage,
    IMinAmountStage,
    IMaxAmountStage,
    IStatusStage,
    IAdditionalParameterStage,
    IBalanceBuilderStage
{
    private readonly GetBalanceResponse _getBalanceResponse = new();

    public IAmountStage WithAbonentInfo(string abonentInfo)
    {
        _getBalanceResponse.AbonentInfo = Forbid.From.NullOrEmpty(abonentInfo);
        return this;
    }

    public IBalanceBuilderStage WithAdditionalParameters(params Parameter[] additionalParameters)
    {
        foreach (var parameter in Forbid.From.NullOrEmpty(additionalParameters))
        {
            Forbid.From.Any(additionalParameters, p => p.Key == parameter.Key,
                ParameterAlreadyExistsException.Instance);
            _getBalanceResponse.AdditionalParameters.Add(parameter);
        }

        return this;
    }

    public IBalanceBuilderStage WithoutAdditionalParameters()
    {
        _getBalanceResponse.AdditionalParameters = default!;
        return this;
    }

    public IMinAmountStage WithAmount(decimal amount)
    {
        _getBalanceResponse.Amount = Forbid.From.Zero(amount);
        return this;
    }

    public GetBalanceResponse Build()
    {
        return _getBalanceResponse;
    }

    public ISecondParameterStage WithFirstParameter(object value)
    {
        Forbid.From.Null(value, ParameterNullException.Instance);
        Forbid.From.Any(_getBalanceResponse.Parameters, parameter => parameter.Key == "param1",
            ParameterAlreadyExistsException.Instance);
        var parameter = new Parameter("param1", value.ToString());
        _getBalanceResponse.Parameters.Add(parameter);
        return this;
    }

    public IStatusStage WithMaxPayAmount(decimal maxPayAmount)
    {
        _getBalanceResponse.MinPayAmount = Forbid.From.Zero(maxPayAmount);
        return this;
    }

    public IStatusStage WithoutMaxPayAmount()
    {
        _getBalanceResponse.MaxPayAmount = null;
        return this;
    }

    public IMaxAmountStage WithMinPayAmount(decimal minPayAmount)
    {
        _getBalanceResponse.MinPayAmount = Forbid.From.Zero(minPayAmount);
        return this;
    }

    public IMaxAmountStage WithoutMinPayAmount()
    {
        _getBalanceResponse.MinPayAmount = null;
        return this;
    }

    public IAbonentInfoStage WithParameters(params Parameter[] parameters)
    {
        foreach (var parameter in Forbid.From.NullOrEmpty(parameters))
        {
            Forbid.From.Any(_getBalanceResponse.Parameters, p => p.Key == parameter.Key,
                ParameterAlreadyExistsException.Instance);
            _getBalanceResponse.Parameters.Add(parameter);
        }

        return this;
    }

    public IFirstParameterStage WithProviderId(int providerId)
    {
        _getBalanceResponse.ProviderId = Forbid.From.Zero(providerId);
        return this;
    }

    public IThirdParameterStage WithSecondParameter(object value)
    {
        Forbid.From.Null(value, ParameterNullException.Instance);
        Forbid.From.Any(_getBalanceResponse.Parameters, parameter => parameter.Key == "param2",
            ParameterAlreadyExistsException.Instance);
        var parameter = new Parameter("param2", value.ToString());
        _getBalanceResponse.Parameters.Add(parameter);
        return this;
    }

    public IAbonentInfoStage WithoutSecondParameter()
    {
        var firstParameter = _getBalanceResponse.Parameters.FirstOrDefault(parameter => parameter.Key == "param1");
        Forbid.From.Null(firstParameter?.Value, exception: ParameterNullException.Instance);
        return this;
    }

    public IAdditionalParameterStage WithStatus(Status status)
    {
        _getBalanceResponse.Status = status;
        return this;
    }

    public IParameterStage WithThirdParameter(object value)
    {
        Forbid.From.Null(value, ParameterNullException.Instance);
        Forbid.From.Any(_getBalanceResponse.Parameters, parameter => parameter.Key == "param3",
            ParameterAlreadyExistsException.Instance);
        var parameter = new Parameter("param3", value.ToString());
        _getBalanceResponse.Parameters.Add(parameter);
        return this;
    }

    public static IProviderIdStage Create()
    {
        return new BalanceResponseBuilder();
    }
}