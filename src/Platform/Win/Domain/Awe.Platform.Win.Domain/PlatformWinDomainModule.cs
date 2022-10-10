using System.Windows.Controls.Ribbon;
using Awe.Core.Action.Core;
using Awe.Core.Widget.Contracts;
using Awe.Core.Widget.Contracts.Builder;
using Awe.Core.Widget.Contracts.Domain;
using Awe.Core.Widget.Domain;
using Awe.Core.Widget.Domain.Builders;
using DevExpress.Utils;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Awe.Platform.Win.Domain;

[DependsOn(typeof(WidgetContractsModule))]
[DependsOn(typeof(WidgetDomainModule))]
[DependsOn(typeof(PlatformWinViewModule))]
[DependsOn(typeof(ActionDomainModule))]
public class PlatformWinDomainModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        base.ConfigureServices(context);

        context.Services.AddSingleton<IWApplicationDomainService, ApplicationWinDomainService>();
        context.Services.AddSingleton<IWMainFormDomainService, MainFormWinDomainService>();
        context.Services.AddSingleton<IMainMenuDomainService, MainMenuWinDomainService>();
        context.Services.AddSingleton<IMainMenuBuilder, MainMenuBuilder>();
    }
}