// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using ProviderConnector.Core.Models.Contracts;
using ProviderConnector.Core.Models.Requests;
using ProviderConnector.Infrastructure.Strategies.GetBalanceStrategy.Factory;
using ProviderConnector.Infrastructure.Strategies.GetBalanceStrategy.Strategy;

Console.WriteLine("Hello, World!");
ICommonProviderFactory commonProviderFactory = new CommonProviderFactory();
IGetBalanceStrategy getBalanceStrategy = new GetBalanceStrategy(commonProviderFactory);
var balance = await getBalanceStrategy.GetBalanceAsync(new GetBalanceRequest
{
    ProviderId = 7016,
    Parameters = new List<Parameter>
    {
        new("param1","2831928")
    }
});

Console.WriteLine($"Abonent: {balance.Abonent} Amount: {balance.Amount}");