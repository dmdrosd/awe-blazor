using Abp.Modules;
using Awe.Core.Action.Contracts;

namespace Awe.Core.Widget.Contracts;

[DependsOn(typeof(ActionContractsModule))]
public class WidgetContractsModule : AbpModule
{
}