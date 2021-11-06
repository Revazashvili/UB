// See https://aka.ms/new-console-template for more information

using ProviderConnector.Core.Models.Requests;
using ProviderConnector.Infrastructure.Persistence;
using ProviderConnector.Infrastructure.Strategies.GetBalanceStrategy.Brokers;
using ProviderConnector.Infrastructure.Strategies.GetBalanceStrategy.Factory;
using ProviderConnector.Infrastructure.Strategies.GetBalanceStrategy.Strategy;

Console.WriteLine("Hello, World!");
var dbContext = new AppDbContext();
var strategyBroker = new StrategyBroker(dbContext);
var providerFactory = new ProviderFactory();
var getBalanceStrategy = new GetBalanceStrategy(providerFactory, strategyBroker);
var balances = await getBalanceStrategy.GetBalanceAsync(new GetBalanceRequest
{
    ProviderId = 7016,
});
var balance = balances.FirstOrDefault();
Console.WriteLine(balance?.ProviderId + balance?.Amount + balance?.AbonentInfo);