using _Blazor.Starter.Global.Nav.Model;
using Abp.Dependency;
using Abp.Domain.Services;
using Awe.Platform.Wasm.Domain.Navigation;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http.Json;
using Awe.Core.Widget.Contracts.Domain;
using Awe.Platform.Wasm.Domain.Config;

namespace Awe.Platform.Wasm.Domain.App;

public class ApplicationWasmDomainService : DomainService, IWApplicationDomainService, ISingletonDependency
{
    public void Start(string[] args)
    {
        throw new NotImplementedException();
    }

    public async Task StartAsync(string[] args)
    {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);

        await ServicesInitialize(builder);

        builder.RootComponents.Add<View.App>("#app");
        builder.RootComponents.Add<HeadOutlet>("head::after");

        // Masa
        await builder.Services
            .AddMasaBlazor(builder =>
            {
                builder.UseTheme(option =>
                {
                    option.Primary = "#4318FF";
                    option.Accent = "#4318FF";
                });
            })
            .AddI18nForWasmAsync(Path.Combine(builder.HostEnvironment.BaseAddress, "i18n"));

        // Devexpress
        builder.Services.AddDevExpressBlazor();
        builder.Services.Configure<DevExpress.Blazor.Configuration.GlobalOptions>(options =>
        {
            options.BootstrapVersion = DevExpress.Blazor.BootstrapVersion.v5;
        });

        await builder.Build().RunAsync();
    }

    private static async Task ServicesInitialize(WebAssemblyHostBuilder builder)
    {
        builder.Services.AddAuthorizationCore();
        builder.Services.AddScoped<AuthenticationStateProvider, TestAuthStateProvider>();
        builder.Services.AddScoped<IConfigDomainService, MasaConfigDomainService>();
        builder.Services.AddScoped<INavigationDomainService, MasaNavigationDomainService>();

        using (var httpClient = new HttpClient())
        {
            var navList = await httpClient.GetFromJsonAsync<List<NavModel>>(Path.Combine(builder.HostEnvironment.BaseAddress, $"nav/nav.json"))
                          ?? throw new Exception("please configure the Navigation!");
            NavLoader.NavList = navList;
        }
    }

    public void Restart()
    {
        throw new NotImplementedException();
    }

    public string ProductInfo { get; }
}