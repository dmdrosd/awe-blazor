using Awe.Core.Action.Application;
using Awe.Core.Widget.Application;
using Awe.Platform.Wasm.Domain;
using Awe.Platform.Wasm.View;
using Volo.Abp.Autofac.WebAssembly;
using Volo.Abp.Identity.Blazor.WebAssembly;
using Volo.Abp.Modularity;
using Volo.Abp.SettingManagement.Blazor.WebAssembly;
using Volo.Abp.TenantManagement.Blazor.WebAssembly;

namespace _Blazor.Starter;

[DependsOn(
    typeof(AbpAutofacWebAssemblyModule)
    //typeof(BookStoreHttpApiClientModule),
    //typeof(AbpAspNetCoreComponentsWebAssemblyBasicThemeModule),
    //typeof(AbpIdentityBlazorWebAssemblyModule),
    //typeof(AbpTenantManagementBlazorWebAssemblyModule),
    //typeof(AbpSettingManagementBlazorWebAssemblyModule)
)]
[DependsOn(typeof(WidgetApplicationModule))]
[DependsOn(typeof(ActionModule))]

/* Platform Wasm realization */
[DependsOn(typeof(PlatformWasmDomainModule))]
[DependsOn(typeof(PlatformWasmViewModule))]
/* Platform Wasm realization */

public class BlazorStarterModule : AbpModule
{
}