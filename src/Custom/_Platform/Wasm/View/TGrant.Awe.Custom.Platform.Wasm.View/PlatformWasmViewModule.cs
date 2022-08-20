using Abp.Modules;
using Abp.Reflection.Extensions;
using TGrant.Awe.Core.Widget.Contracts;

namespace TGrant.Awe.Custom.Platform.Wasm.View;

[DependsOn(typeof(WidgetContractsModule))]
public class PlatformWasmViewModule : AbpModule
{
    public override void Initialize()
    {
        IocManager.RegisterAssemblyByConvention(GetType().GetAssembly());
    }
}