using MediatR;
using ProviderConnector.Core.Models.Requests;
using ProviderConnector.Core.Models.Responses;
using ProviderConnector.Infrastructure.SharedKernel.Factories;

namespace ProviderConnector.Core.Events.Commands;

public record PayCommand(PaymentRequest PaymentRequest) : IRequest<PaymentResponse>;

public class PayCommandHandler : IRequestHandler<PayCommand, PaymentResponse>
{
    private readonly IProviderFactory _providerFactory;

    public PayCommandHandler(IProviderFactory providerFactory)
    {
        _providerFactory = providerFactory;
    }
    
    public async Task<PaymentResponse> Handle(PayCommand request, CancellationToken cancellationToken)
    {
        var provider = _providerFactory.CreateProvider(request.PaymentRequest.ProviderId);
        return await provider.PayAsync(request.PaymentRequest);
    }
}