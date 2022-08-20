using Abp.Modules;
using TGrant.Awe.Core.Action.Application;
using TGrant.Awe.Core.Widget.Application;
using TGrant.Awe.Custom.Platform.Wasm.Domain;
using TGrant.Awe.Custom.Platform.Wasm.View;

namespace _Blazor.Starter;


[DependsOn(typeof(WidgetApplicationModule))]
[DependsOn(typeof(ActionModule))]

/* Platform Wasm realization */
[DependsOn(typeof(PlatformWasmDomainModule))]
[DependsOn(typeof(PlatformWasmViewModule))]
/* Platform Wasm realization */

public class BlazorStarterModule : AbpModule
{
}