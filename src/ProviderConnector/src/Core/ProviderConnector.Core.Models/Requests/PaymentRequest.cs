using System;
using ProviderConnector.Core.Models.Common;

namespace ProviderConnector.Core.Models.Requests;

/// <summary>
///     Payment request model.
/// </summary>
public class PaymentRequest : Base
{
    /// <summary>
    ///     Gets or sets payment identifier.
    /// </summary>
    public int PaymentId { get; set; }

    /// <summary>
    ///     Gets or sets operation date.
    /// </summary>
    public DateTime OperationDate { get; set; }

    /// <summary>
    ///     Gets or sets payed money amount.
    /// </summary>
    public decimal PayingAmount { get; set; }

    /// <summary>
    ///     Gets or sets current balance.
    /// </summary>
    public decimal CurrentBalance { get; set; }

    /// <summary>
    ///     Gets or sets operation finalize time.
    /// </summary>
    public DateTime FinalizeTime { get; set; }

    /// <summary>
    ///     Gets or sets additional information about operation.
    /// </summary>
    public string AdditionalInfo { get; set; } = null!;
}