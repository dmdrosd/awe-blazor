using Abp.Dependency;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Awe.Core.Action.Core;
using Awe.Core.Widget.Contracts;
using Awe.Core.Widget.Contracts.Builder;
using Awe.Core.Widget.Contracts.Domain;
using Awe.Core.Widget.Domain;
using Awe.Core.Widget.Domain.Builders;

namespace Awe.Platform.Win.Domain;

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