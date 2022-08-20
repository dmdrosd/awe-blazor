using Abp.Modules;

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