using _Blazor.Starter.Global.Nav.Model;
using Awe.Platform.Wasm.Domain.Navigation;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http.Json;
using Awe.Core.Widget.Contracts.Domain;
using Awe.Platform.Wasm.Domain.Config;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Services;

namespace Awe.Platform.Wasm.Domain.App;

public class ApplicationWasmDomainService : DomainService, IWApplicationDomainService, ISingletonDependency
{
    private readonly WebAssemblyHostBuilder _builder;
    private readonly WebAssemblyHost host;

    public ApplicationWasmDomainService(WebAssemblyHostBuilder builder, WebAssemblyHost host)
    {
        this._builder = builder;
        this.host = host;
    }

    public void Start(string[] args)
    {
        throw new NotImplementedException();
    }

    public async Task StartAsync(string[] args)
    {
        //TODO move to module init
        await ServicesInitialize(_builder);

        _builder.RootComponents.Add<View.App>("#app");
        _builder.RootComponents.Add<HeadOutlet>("head::after");

        // Masa
        await _builder.Services
            .AddMasaBlazor(builder =>
            {
                builder.UseTheme(option =>
                {
                    option.Primary = "#4318FF";
                    option.Accent = "#4318FF";
                });
            })
            .AddI18nForWasmAsync(Path.Combine(_builder.HostEnvironment.BaseAddress, "i18n"));

        // Devexpress
        _builder.Services.AddDevExpressBlazor();
        _builder.Services.Configure<DevExpress.Blazor.Configuration.GlobalOptions>(options =>
        {
            options.BootstrapVersion = DevExpress.Blazor.BootstrapVersion.v5;
        });

        //var application = await _builder.AddApplicationAsync<PlatformWasmDomainModule>(options =>
        //{
        //    options.UseAutofac();
        //});

        //var host = _builder.Build();

        //await application.InitializeApplicationAsync(host.Services);

        await host.RunAsync();
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