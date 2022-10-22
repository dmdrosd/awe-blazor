using Abp.Dependency;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Awe.Core.Action.Core;
using Awe.Core.Widget.Contracts;
using Awe.Core.Widget.Domain;
using Awe.Core.Widget.Domain.Builders;
using Awe.Custom.Platform.Wasm.View;
using Awe.Platform.Wasm.Domain.App;
using Awe.Platform.Wasm.Domain.MainForm;
using Awe.Core.Widget.Contracts.Builder;
using Awe.Core.Widget.Contracts.Domain;

namespace Awe.Platform.Wasm.Domain;

[DependsOn(typeof(WidgetContractsModule))]
[DependsOn(typeof(WidgetDomainModule))]
[DependsOn(typeof(ActionDomainModule))]

[DependsOn(typeof(PlatformWasmViewModule))]
public class PlatformWasmDomainModule : AbpModule
{
    public override void PreInitialize()
    {
        base.PreInitialize();

        IocManager.Register<IWApplicationDomainService, ApplicationWasmDomainService>();
        
        IocManager.Register<IWMainFormDomainService, MainFormWasmDomainService>();
        
        IocManager.Register<IMainMenuDomainService, MainMenuWasmDomainService>();
        IocManager.Register<IMainMenuBuilder, MainMenuBuilder>(DependencyLifeStyle.Singleton);
    }

    public override void Initialize()
    {
        IocManager.RegisterAssemblyByConvention(GetType().GetAssembly());
    }
}