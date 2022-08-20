using Abp.Dependency;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using TGrant.Awe.Core.Widget.Contracts;
using TGrant.Awe.Core.Widget.Contracts.View;
using TGrant.Awe.Core.Widget.Contracts.View.MainMenu.MainMenuItem;
using TGrant.Awe.Core.Widget.Contracts.View.Page;
using TGrant.Awe.Custom.Platform.Win.View.MainFormView;
using TGrant.Awe.Custom.Platform.Win.View.MainFormView.MainMenu;
using TGrant.Awe.Custom.Platform.Win.View.Page;

namespace TGrant.Awe.Custom.Platform.Win.View;

[DependsOn(typeof(WidgetContractsModule))]
public class PlatformWinViewModule : AbpModule
{
    public override void PreInitialize()
    {
        base.PreInitialize();

        IocManager.Register<IMainFormView, MainForm>();
        IocManager.Register<IPageView, PageView>();

        IocManager.Register<IMainMenuItemButtonView, MainMenuItemButton>(DependencyLifeStyle.Transient);
        IocManager.Register<BarButtonItem>(DependencyLifeStyle.Transient);
        IocManager.Register<IMainMenuItemGroupView, MainMenuItemGroup>(DependencyLifeStyle.Transient);
        IocManager.Register<RibbonPageGroup>(DependencyLifeStyle.Transient);
    }

    public override void Initialize()
    {
        IocManager.RegisterAssemblyByConvention(GetType().GetAssembly());
    }
}