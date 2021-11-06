using ProviderConnector.Core.Models.Enums;

namespace ProviderConnector.Core.Models.Responses;
using Common;

/// <summary>
/// Base response model
/// </summary>
public class Response : Base
{
    protected Response() => AdditionalParameters = new List<Parameter>();

    public Status Status { get; set; }
    public List<Parameter> AdditionalParameters { get; set; }
}