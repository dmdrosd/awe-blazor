using System.Net.Http;
using System.Net.Http.Json;
using System.Reflection;
using _Blazor.Starter.Global.Nav.Model;
using Microsoft.Extensions.DependencyInjection;
using TGrant.Awe.Custom.Platform.Wasm.Domain.Config;
using TGrant.Awe.Custom.Platform.Wasm.Domain.Navigation;

namespace TGrant.Awe.Custom.Platform.Wasm.Domain;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddGlobalForServer(this IServiceCollection services)
    {
        var basePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) 
                       ?? throw new Exception("Get the assembly root directory exception!");
        // services.AddNav(Path.Combine(basePath, $"wwwroot/nav/nav.json"));
        // services.AddScoped<GlobalConfig>();

        return services;
    }

    public static async Task<IServiceCollection> AddGlobalForWasmAsync(this IServiceCollection services, string baseUri)
    {
        using (var httpClient = new HttpClient())
        {
            var navList = await httpClient.GetFromJsonAsync<List<NavModel>>(Path.Combine(baseUri, $"nav/nav.json"))
                          ?? throw new Exception("please configure the Navigation!");
            NavLoader.NavList = navList;
        }
        
        // services.AddNav(navList);
        services.AddScoped<IConfigDomainService, MasaConfigDomainService>();
        services.AddScoped<INavigationDomainService, MasaNavigationDomainService>();

        return services;
    }
}