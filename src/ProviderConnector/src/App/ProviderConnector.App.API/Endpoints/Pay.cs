using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using ProviderConnector.Core.Events.Commands;
using ProviderConnector.Core.Models.Requests;
using ProviderConnector.Core.Models.Responses;
using Swashbuckle.AspNetCore.Annotations;

namespace ProviderConnector.App.API.Endpoints;

public class Pay : EndpointBaseAsync
    .WithRequest<PaymentRequest>
    .WithActionResult<PaymentResponse>
{
    private readonly IMediator _mediator;

    public Pay(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost, SwaggerOperation(Summary = "Inform provider about payment", OperationId = "Pay")]
    public override async Task<ActionResult<PaymentResponse>> HandleAsync(PaymentRequest request,
        CancellationToken cancellationToken = new()) =>
        Ok(await _mediator.Send(new PayCommand(request), cancellationToken));
}