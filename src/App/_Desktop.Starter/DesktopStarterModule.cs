using Abp.Modules;
using TGrant.Awe.Core.Action.Application;
using TGrant.Awe.Core.Widget.Application;
using TGrant.Awe.Custom.Platform.Win.Domain;
using TGrant.Awe.Custom.Platform.Win.View;

namespace TGrant.Awe.Starter;

[DependsOn(typeof(WidgetApplicationModule))]
[DependsOn(typeof(ActionModule))]

/* Platform Win realization */
[DependsOn(typeof(PlatformWinDomainModule))]
[DependsOn(typeof(PlatformWinViewModule))]
/* Platform Win realization */

public class DesktopStarterModule : AbpModule
{
}