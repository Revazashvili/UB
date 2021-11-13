﻿using ProviderConnector.Core.Models.Enums;
using ProviderConnector.Core.Models.Responses;

namespace ProviderConnector.Infrastructure.SharedKernel.Builders.BalanceResponse;

public interface IStatusStage
{
    /// <summary>
    ///     Adds status to <see cref="GetBalanceResponse" /> instance.
    /// </summary>
    /// <param name="status"><see cref="Status" />.</param>
    IAdditionalParameterStage WithStatus(Status status);
}