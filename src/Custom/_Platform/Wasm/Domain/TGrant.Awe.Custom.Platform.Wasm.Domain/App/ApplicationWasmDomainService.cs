using Abp.Dependency;
using Abp.Domain.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using TGrant.Awe.Core.Widget.Contracts.Domain;

namespace TGrant.Awe.Custom.Platform.Wasm.Domain.App;

public class ApplicationWasmDomainService : DomainService, IWApplicationDomainService, ISingletonDependency
{
    public void Start(string[] args)
    {
        throw new NotImplementedException();
    }

    public async Task StartAsync(string[] args)
    {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);
        builder.RootComponents.Add<View.App>("#app");
        builder.RootComponents.Add<HeadOutlet>("head::after");

        builder.Services.AddDevExpressBlazor();
        builder.Services.Configure<DevExpress.Blazor.Configuration.GlobalOptions>(options =>
        {
            options.BootstrapVersion = DevExpress.Blazor.BootstrapVersion.v5;
        });

        builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

        await builder.Build().RunAsync();
    }

    public void Restart()
    {
        throw new NotImplementedException();
    }

    public string ProductInfo { get; }
}