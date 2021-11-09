namespace ProviderConnector.Core.Events.Queries;
using MediatR;
using Models.Requests;
using Models.Responses;
using Infrastructure.Factories.Factories.Interfaces;

public record GetBalanceQuery(GetBalanceRequest BalanceRequest) : IRequest<IEnumerable<GetBalanceResponse>>;

public class GetBalanceQueryHandler : IRequestHandler<GetBalanceQuery, IEnumerable<GetBalanceResponse>>
{
    private readonly IProviderFactory _providerFactory;

    public GetBalanceQueryHandler(IProviderFactory providerFactory) => _providerFactory = providerFactory;

    public async Task<IEnumerable<GetBalanceResponse>> Handle(GetBalanceQuery request, CancellationToken cancellationToken)
    {
        var provider = _providerFactory.CreateProvider(request.BalanceRequest.ProviderId);
        var getBalanceResponses = await provider.GetBalanceAsync(request.BalanceRequest);
        return getBalanceResponses;
    }
}