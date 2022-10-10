using Awe.Core.Widget.Application.Interfaces;
using Awe.Core.Widget.Contracts;
using Volo.Abp.Modularity;

namespace Awe.Core.Widget.Application;

[DependsOn(typeof(WidgetContractsModule))]
public class WidgetApplicationModule : AbpModule
{
}