// See https://aka.ms/new-console-template for more information

using ProviderConnector.Core.Models.Requests;
using ProviderConnector.Infrastructure.Strategies.GetBalanceStrategy.Factory;
using ProviderConnector.Infrastructure.Strategies.GetBalanceStrategy.Strategy;

Console.WriteLine("Hello, World!");
IProviderFactory commonProviderFactory = new ProviderFactory();
IGetBalanceStrategy getBalanceStrategy = new GetBalanceStrategy(commonProviderFactory);
var balance = await getBalanceStrategy.GetBalanceAsync(new GetBalanceRequest
{
    ProviderId = 7016,
});