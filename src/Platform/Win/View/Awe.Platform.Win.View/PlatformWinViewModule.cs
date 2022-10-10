using Awe.Core.Widget.Contracts;
using Awe.Core.Widget.Contracts.View.MainForm;
using Awe.Core.Widget.Contracts.View.MainMenu.MainMenuItem;
using Awe.Platform.Win.View.MainFormView;
using Awe.Platform.Win.View.MainFormView.MainMenu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Awe.Platform.Win.View;

[DependsOn(typeof(WidgetContractsModule))]
public class PlatformWinViewModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        base.ConfigureServices(context);

        context.Services.AddSingleton<RibbonControl>();
        context.Services.AddSingleton<IMainFormView, MainForm>();

        context.Services.AddTransient<BarButtonItem>();
        context.Services.AddTransient<RibbonPageGroup>();

        context.Services.AddTransient<IMainMenuItemButtonView, MainMenuItemButton>();
        context.Services.AddTransient<IMainMenuItemGroupView, MainMenuItemGroup>();
    }
}