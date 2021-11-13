using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using ProviderConnector.Core.Models.Requests;
using ProviderConnector.Core.Models.Responses;
using ProviderConnector.Infrastructure.SharedKernel.Factories;

namespace ProviderConnector.Core.Events.Queries;

public record GetBalanceQuery(GetBalanceRequest BalanceRequest) : IRequest<IEnumerable<GetBalanceResponse>>;

public class GetBalanceQueryHandler : IRequestHandler<GetBalanceQuery, IEnumerable<GetBalanceResponse>>
{
    private readonly IProviderFactory _providerFactory;

    public GetBalanceQueryHandler(IProviderFactory providerFactory)
    {
        _providerFactory = providerFactory;
    }

    public async Task<IEnumerable<GetBalanceResponse>> Handle(GetBalanceQuery request,
        CancellationToken cancellationToken)
    {
        var provider = _providerFactory.CreateProvider(request.BalanceRequest.ProviderId);
        var getBalanceResponses = await provider.GetBalanceAsync(request.BalanceRequest);
        return getBalanceResponses;
    }
}