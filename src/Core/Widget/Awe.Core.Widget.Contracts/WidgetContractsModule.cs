using Awe.Core.Action.Contracts;
using Volo.Abp.Modularity;

namespace Awe.Core.Widget.Contracts;

[DependsOn(typeof(ActionContractsModule))]
public class WidgetContractsModule : AbpModule
{
}