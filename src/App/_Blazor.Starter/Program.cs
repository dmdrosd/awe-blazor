using _Blazor.Starter;
using Awe.Core.Widget.Application.Interfaces;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

var application = await builder.AddApplicationAsync<BlazorStarterModule>(options =>
{
    options.UseAutofac();
});

var host = builder.Build();

await application.InitializeApplicationAsync(host.Services);

builder.Services.AddSingleton(builder);
builder.Services.AddSingleton(host);

await builder.Services
    .GetRequiredService<IWApplicationService>()
    .StartAsync(args);