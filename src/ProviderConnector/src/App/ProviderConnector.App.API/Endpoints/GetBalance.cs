namespace ProviderConnector.App.API.Endpoints;
using MediatR;
using Swashbuckle.AspNetCore.Annotations;
using Microsoft.AspNetCore.Mvc;
using Core.Events.Queries;
using Core.Models.Requests;
using Core.Models.Responses;
using Ardalis.ApiEndpoints;

[Route("api/balance")]
public class GetBalance : EndpointBaseAsync
    .WithRequest<GetBalanceRequest>
    .WithActionResult<IEnumerable<GetBalanceResponse>>
{
    private readonly IMediator _mediator;

    public GetBalance(IMediator mediator) => _mediator = mediator;

    [HttpGet,
        SwaggerOperation(Summary = "Return Provider balance.",OperationId = "Balance",Tags = new []{ "Balance" })]
    public override async Task<ActionResult<IEnumerable<GetBalanceResponse>>> HandleAsync(GetBalanceRequest request,
        CancellationToken cancellationToken = new()) =>
        Ok(await _mediator.Send(new GetBalanceQuery(request), cancellationToken));
}