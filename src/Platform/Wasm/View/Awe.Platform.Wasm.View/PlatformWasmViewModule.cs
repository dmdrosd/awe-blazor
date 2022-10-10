using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Awe.Platform.Wasm.View;

[DependsOn(typeof(WidgetContractsModule))]
public class PlatformWasmViewModule : AbpModule
{
}