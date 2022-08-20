using _Blazor.Starter;
using _Blazor.Starter.WebAssembly;
using Abp;
using Awe.Platform.Wasm.Domain;
using Awe.Platform.Wasm.View;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

using (var bootstrapper = AbpBootstrapper.Create<BlazorStarterModule>())
{
    //bootstrapper.IocManager.IocContainer.AddFacility<LoggingFacility>(f =>
    //    f.UseAbpLog4Net().WithConfig("log4net.config"));

    bootstrapper.Initialize();

    //Application.EnableVisualStyles();
    //Application.SetCompatibleTextRenderingDefault(false);
    //Application.Run(bootstrapper.IocManager.Resolve<MainForm>());
}

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<AuthenticationStateProvider, TestAuthStateProvider>();

await builder.Services.AddGlobalForWasmAsync(builder.HostEnvironment.BaseAddress);

builder.RootComponents.Add(typeof(App), "#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
await builder.Services.AddMasaBlazor(builder =>
{
    builder.UseTheme(option =>
    {
        option.Primary = "#4318FF";
        option.Accent = "#4318FF";
    });
}).AddI18nForWasmAsync(Path.Combine(builder.HostEnvironment.BaseAddress, "i18n"));


await builder.Build().RunAsync();