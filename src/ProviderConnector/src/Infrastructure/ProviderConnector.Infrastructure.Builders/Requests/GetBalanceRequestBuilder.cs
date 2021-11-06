using Forbids;
using ProviderConnector.Core.Models.Common;
using ProviderConnector.Core.Models.Requests;
using ProviderConnector.Infrastructure.Builders.Exceptions;

namespace ProviderConnector.Infrastructure.Builders.Requests;

/// <summary>
/// Builder class to build <see cref="GetBalanceRequest"/> step by step.
/// </summary>
public class GetBalanceRequestBuilder
{
    /// <summary>
    /// Instance of <see cref="Parameter"/> class.
    /// </summary>
    private GetBalanceRequest _getBalanceRequest = new();

    /// <summary>
    /// Initializes new instance of <see cref="GetBalanceRequestBuilder"/>.
    /// </summary>
    public GetBalanceRequestBuilder() { }
    
    /// <summary>
    /// Initializes new instance of <see cref="GetBalanceRequest"/> with provided provider id.
    /// </summary>
    /// <param name="providerId">Provider identifier.</param>
    public GetBalanceRequestBuilder(int providerId) => _getBalanceRequest.ProviderId = Forbid.From.Zero(providerId);

    /// <summary>
    /// Adds provider id to <see cref="GetBalanceRequest"/> instance.
    /// </summary>
    /// <param name="providerId">Provider identifier.</param>
    /// <returns>Reference to <see cref="GetBalanceRequestBuilder"/> object.</returns>
    public GetBalanceRequestBuilder WithProviderId(int providerId)
    {
        _getBalanceRequest.ProviderId = Forbid.From.Zero(providerId);
        return this;
    }

    /// <summary>
    /// Adds parameter to <see cref="GetBalanceRequest"/> instance.
    /// </summary>
    /// <param name="parameter"><see cref="Parameter"/>.</param>
    /// <returns>Reference to <see cref="GetBalanceRequestBuilder"/> object.</returns>
    public GetBalanceRequestBuilder WithParameter(Parameter parameter)
    {
        Forbid.From.True(_getBalanceRequest.Parameters.Any(p => p.Key == parameter.Key),
            new ParameterAlreadyExistsException());
        _getBalanceRequest.Parameters.Add(Forbid.From.Null(parameter,new ParameterNullException()));
        return this;
    }

    /// <summary>
    /// Adds parameter to <see cref="GetBalanceRequest"/> instance.
    /// </summary>
    /// <param name="value"><see cref="Parameter"/> value.</param>
    /// <returns>Reference to <see cref="GetBalanceRequestBuilder"/> object.</returns>
    public GetBalanceRequestBuilder WithFirstParameter(object value)
    {
        Forbid.From.True(_getBalanceRequest.Parameters.Any(parameter => parameter.Key == "param1"),
            new ParameterAlreadyExistsException());
        var parameter = new Parameter("param1", Forbid.From.Null(value).ToString());
        _getBalanceRequest.Parameters.Add(parameter);
        return this;
    }
    
    /// <summary>
    /// Adds parameter to <see cref="GetBalanceRequest"/> instance.
    /// </summary>
    /// <param name="value"><see cref="Parameter"/> value.</param>
    /// <returns>Reference to <see cref="GetBalanceRequestBuilder"/> object.</returns>
    public GetBalanceRequestBuilder WithSecondParameter(object value)
    {
        Forbid.From.True(_getBalanceRequest.Parameters.Any(parameter => parameter.Key == "param2"),
            new ParameterAlreadyExistsException());
        var parameter = new Parameter("param2", Forbid.From.Null(value).ToString());
        _getBalanceRequest.Parameters.Add(parameter);
        return this;
    }
    
    /// <summary>
    /// Adds parameter to <see cref="GetBalanceRequest"/> instance.
    /// </summary>
    /// <param name="value"><see cref="Parameter"/> value.</param>
    /// <returns>Reference to <see cref="GetBalanceRequestBuilder"/> object.</returns>
    public GetBalanceRequestBuilder WithThirdParameter(object value)
    {
        Forbid.From.True(_getBalanceRequest.Parameters.Any(parameter => parameter.Key == "param3"),
            new ParameterAlreadyExistsException());
        var parameter = new Parameter("param3", Forbid.From.Null(value).ToString());
        _getBalanceRequest.Parameters.Add(parameter);
        return this;
    }
}