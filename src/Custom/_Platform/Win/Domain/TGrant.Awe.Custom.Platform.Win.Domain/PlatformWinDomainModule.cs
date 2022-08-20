using Abp.Dependency;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TGrant.Awe.Core.Action.Core;
using TGrant.Awe.Core.Widget.Contracts.Builder;
using TGrant.Awe.Core.Widget.Contracts.Domain;
using TGrant.Awe.Core.Widget.Domain;
using TGrant.Awe.Custom.Platform.Widget.Domain.Win.MainForm;
using TGrant.Awe.Custom.Platform.Win.Domain.App;
using TGrant.Awe.Custom.Platform.Win.Domain.MainForm;
using TGrant.Awe.Custom.Platform.Win.View;

namespace TGrant.Awe.Custom.Platform.Win.Domain;

[DependsOn(typeof(WidgetContractsModule))]
[DependsOn(typeof(WidgetDomainModule))]
[DependsOn(typeof(PlatformWinViewModule))]
[DependsOn(typeof(ActionDomainModule))]
public class PlatformWinDomainModule : AbpModule
{
    public override void PreInitialize()
    {
        base.PreInitialize();

        IocManager.Register<IWApplicationDomainService, ApplicationWinDomainService>();
        
        IocManager.Register<IWMainFormDomainService, MainFormWinDomainService>();
        
        IocManager.Register<IMainMenuDomainService, MainMenuWinDomainService>();
        IocManager.Register<IMainMenuBuilder, MainMenuBuilder>(DependencyLifeStyle.Singleton);
    }

    public override void Initialize()
    {
        IocManager.RegisterAssemblyByConvention(GetType().GetAssembly());
    }
}