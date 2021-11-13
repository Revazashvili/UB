using ProviderConnector.Core.Models.Common;
using ProviderConnector.Core.Models.Enums;

namespace ProviderConnector.Core.Models.Responses;

/// <summary>
///     Base response model
/// </summary>
public class Response : Base
{
    public Status Status { get; set; }
}