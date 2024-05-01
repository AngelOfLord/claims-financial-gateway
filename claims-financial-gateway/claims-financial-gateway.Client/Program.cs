using claims_financial_gateway.Services.Interfaces;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using Services.Implementations;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services
    .AddMudServices()
    .AddSingleton<IBatchService, BatchService>();

await builder.Build().RunAsync();
