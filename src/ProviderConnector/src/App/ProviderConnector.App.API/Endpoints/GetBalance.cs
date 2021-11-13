using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using ProviderConnector.Core.Events.Queries;
using ProviderConnector.Core.Models.Requests;
using ProviderConnector.Core.Models.Responses;
using Swashbuckle.AspNetCore.Annotations;

namespace ProviderConnector.App.API.Endpoints;

[Route("api/balance")]
public class GetBalance : EndpointBaseAsync
    .WithRequest<GetBalanceRequest>
    .WithActionResult<IEnumerable<GetBalanceResponse>>
{
    private readonly IMediator _mediator;

    public GetBalance(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    [SwaggerOperation(Summary = "Return Provider balance.", OperationId = "Balance", Tags = new[] { "Balance" })]
    public override async Task<ActionResult<IEnumerable<GetBalanceResponse>>> HandleAsync(GetBalanceRequest request,
        CancellationToken cancellationToken = new()) =>
        Ok(await _mediator.Send(new GetBalanceQuery(request), cancellationToken));
}