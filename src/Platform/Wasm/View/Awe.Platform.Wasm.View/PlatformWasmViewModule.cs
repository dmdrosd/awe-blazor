using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Awe.Custom.Platform.Wasm.View;

[DependsOn(typeof(WidgetContractsModule))]
public class PlatformWasmViewModule : AbpModule
{
    public override void Initialize()
    {
        IocManager.RegisterAssemblyByConvention(GetType().GetAssembly());
    }
}