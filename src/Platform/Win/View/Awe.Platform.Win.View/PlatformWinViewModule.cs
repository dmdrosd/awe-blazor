using Abp.Dependency;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Awe.Core.Widget.Contracts;
using Awe.Platform.Win.View.MainFormView;
using Awe.Platform.Win.View.MainFormView.MainMenu;
using Awe.Platform.Win.View.Page;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;

namespace Awe.Platform.Win.View;

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