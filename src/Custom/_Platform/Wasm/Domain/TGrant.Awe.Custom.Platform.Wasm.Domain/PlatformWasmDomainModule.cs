using Abp.Dependency;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TGrant.Awe.Core.Action.Core;
using TGrant.Awe.Core.Widget.Contracts;
using TGrant.Awe.Core.Widget.Contracts.Builder;
using TGrant.Awe.Core.Widget.Contracts.Domain;
using TGrant.Awe.Core.Widget.Domain;
using TGrant.Awe.Custom.Platform.Wasm.Domain.App;
using TGrant.Awe.Custom.Platform.Wasm.Domain.MainForm;
using TGrant.Awe.Custom.Platform.Wasm.Domain.Page;
using TGrant.Awe.Custom.Platform.Wasm.View;
using TGrant.Awe.Custom.Platform.Widget.Domain.Win.MainForm;

namespace TGrant.Awe.Custom.Platform.Wasm.Domain;

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