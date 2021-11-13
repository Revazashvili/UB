using Forbids;
using ProviderConnector.Core.Models.Common;
using ProviderConnector.Core.Models.Enums;
using ProviderConnector.Core.Models.Responses;
using ProviderConnector.Infrastructure.SharedKernel.Builders.ResponseBuilder.Exceptions;

namespace ProviderConnector.Infrastructure.SharedKernel.Builders.ResponseBuilder.Responses;

/// <summary>
/// Builder class for <see cref="GetBalanceResponse"/>.
/// </summary>
public class GetBalanceResponseBuilder
{
    /// <summary>
    /// Instance of <see cref="GetBalanceResponse"/> class.
    /// </summary>
    private GetBalanceResponse _getBalanceResponse = new();
    
    
    /// <summary>
    /// Adds provider id to <see cref="GetBalanceResponse"/> instance.
    /// </summary>
    /// <param name="providerId">Provider identifier.</param>
    /// <returns>Reference to <see cref="GetBalanceResponseBuilder"/> object.</returns>
    public GetBalanceResponseBuilder WithProviderId(int providerId)
    {
        _getBalanceResponse.ProviderId = Forbid.From.Zero(providerId);
        return this;
    }

    /// <summary>
    /// Adds parameter to <see cref="GetBalanceResponse"/> instance.
    /// </summary>
    /// <param name="parameter"><see cref="Parameter"/>.</param>
    /// <returns>Reference to <see cref="GetBalanceResponseBuilder"/> object.</returns>
    public GetBalanceResponseBuilder WithParameter(Parameter parameter)
    {
        Forbid.From.Null(parameter, ParameterNullException.Instance);
        Forbid.From.True(_getBalanceResponse.Parameters.Any(p => p.Key == parameter.Key),
            ParameterAlreadyExistsException.Instance);
        _getBalanceResponse.Parameters.Add(parameter);
        return this;
    }

    /// <summary>
    /// Adds parameter to <see cref="GetBalanceResponse"/> instance.
    /// </summary>
    /// <param name="value"><see cref="Parameter"/> value.</param>
    /// <returns>Reference to <see cref="GetBalanceResponseBuilder"/> object.</returns>
    public GetBalanceResponseBuilder WithFirstParameter(object value)
    {
        Forbid.From.Null(value, ParameterNullException.Instance);
        Forbid.From.True(_getBalanceResponse.Parameters.Any(parameter => parameter.Key == "param1"),
            ParameterAlreadyExistsException.Instance);
        var parameter = new Parameter("param1", value.ToString());
        _getBalanceResponse.Parameters.Add(parameter);
        return this;
    }
    
    /// <summary>
    /// Adds parameter to <see cref="GetBalanceResponse"/> instance.
    /// </summary>
    /// <param name="value"><see cref="Parameter"/> value.</param>
    /// <returns>Reference to <see cref="GetBalanceResponseBuilder"/> object.</returns>
    public GetBalanceResponseBuilder WithSecondParameter(object value)
    {
        Forbid.From.Null(value, ParameterNullException.Instance);
        Forbid.From.True(_getBalanceResponse.Parameters.Any(parameter => parameter.Key == "param2"),
            ParameterAlreadyExistsException.Instance);
        var parameter = new Parameter("param2", value.ToString());
        _getBalanceResponse.Parameters.Add(parameter);
        return this;
    }
    
    /// <summary>
    /// Adds parameter to <see cref="GetBalanceResponse"/> instance.
    /// </summary>
    /// <param name="value"><see cref="Parameter"/> value.</param>
    /// <returns>Reference to <see cref="GetBalanceResponseBuilder"/> object.</returns>
    public GetBalanceResponseBuilder WithThirdParameter(object value)
    {
        Forbid.From.Null(value, ParameterNullException.Instance);
        Forbid.From.True(_getBalanceResponse.Parameters.Any(parameter => parameter.Key == "param3"),
            ParameterAlreadyExistsException.Instance);
        var parameter = new Parameter("param3", value.ToString());
        _getBalanceResponse.Parameters.Add(parameter);
        return this;
    }

    /// <summary>
    /// Adds amount to <see cref="GetBalanceResponse"/> instance.
    /// </summary>
    /// <param name="amount">The payed money amount.</param>
    /// <returns>Reference to <see cref="GetBalanceResponseBuilder"/> object.</returns>
    public GetBalanceResponseBuilder WithAmount(decimal amount)
    {
        Forbid.From.Zero(amount);
        _getBalanceResponse.Amount = amount;
        return this;
    }
    
    /// <summary>
    /// Adds min pay amount to <see cref="GetBalanceResponse"/> instance.
    /// </summary>
    /// <param name="minPayAmount">The min money amount.</param>
    /// <returns>Reference to <see cref="GetBalanceResponseBuilder"/> object.</returns>
    public GetBalanceResponseBuilder WithMinPayAmount(decimal minPayAmount)
    {
        Forbid.From.Zero(minPayAmount);
        _getBalanceResponse.MinPayAmount = minPayAmount;
        return this;
    }
    
    /// <summary>
    /// Adds max pay amount to <see cref="GetBalanceResponse"/> instance.
    /// </summary>
    /// <param name="maxPayAmount">The max money amount.</param>
    /// <returns>Reference to <see cref="GetBalanceResponseBuilder"/> object.</returns>
    public GetBalanceResponseBuilder WithMaxPayAmount(decimal maxPayAmount)
    {
        Forbid.From.Zero(maxPayAmount);
        _getBalanceResponse.MinPayAmount = maxPayAmount;
        return this;
    }

    /// <summary>
    /// Adds abonent info to <see cref="GetBalanceResponse"/> instance.
    /// </summary>
    /// <param name="abonentInfo">The abonent info.</param>
    /// <returns>Reference to <see cref="GetBalanceResponseBuilder"/> object.</returns>
    public GetBalanceResponseBuilder WithAbonentInfo(string abonentInfo)
    {
        Forbid.From.NullOrEmpty(abonentInfo);
        _getBalanceResponse.AbonentInfo = abonentInfo;
        return this;
    }

    /// <summary>
    /// Adds status to <see cref="GetBalanceResponse"/> instance.
    /// </summary>
    /// <param name="status"><see cref="Status"/>.</param>
    /// <returns>Reference to <see cref="GetBalanceResponseBuilder"/> object.</returns>
    public GetBalanceResponseBuilder WithStatus(Status status)
    {
        _getBalanceResponse.Status = status;
        return this;
    }

    /// <summary>
    /// Adds parameter to <see cref="GetBalanceResponse"/> instance.
    /// </summary>
    /// <param name="parameter"><see cref="Parameter"/></param>
    /// <returns>Reference to <see cref="GetBalanceResponseBuilder"/> object.</returns>    
    public GetBalanceResponseBuilder WithAdditionalParameter(Parameter parameter)
    {
        Forbid.From.Null(parameter, ParameterNullException.Instance);
        Forbid.From.True(_getBalanceResponse.AdditionalParameters.Any(p => p.Key == parameter.Key),
            ParameterAlreadyExistsException.Instance);
        _getBalanceResponse.AdditionalParameters.Add(parameter);
        return this;
    }

    /// <summary>
    /// Adds Error status to <see cref="GetBalanceResponse"/> instance.
    /// </summary>
    ///  <returns>Reference to <see cref="GetBalanceResponseBuilder"/> object.</returns>
    public GetBalanceResponseBuilder Failed()
    {
        _getBalanceResponse.Status = Status.Error;
        return this;
    }

    /// <summary>
    /// Returns built <see cref="GetBalanceResponse"/>.
    /// </summary>
    /// <returns><see cref="GetBalanceResponse"/> instance.</returns>
    public GetBalanceResponse Build() => _getBalanceResponse;
}