using Abp.Modules;
using TGrant.Awe.Core.Action.Contracts;

namespace TGrant.Awe.Core.Widget.Contracts;

[DependsOn(typeof(ActionContractsModule))]
public class WidgetContractsModule : AbpModule
{
}