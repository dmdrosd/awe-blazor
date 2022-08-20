using Abp.Modules;
using Awe.Core.Action.Application;
using Awe.Core.Widget.Application;
using Awe.Custom.Platform.Wasm.View;
using Awe.Platform.Wasm.Domain;

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