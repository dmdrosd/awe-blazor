using Volo.Abp.Modularity;

namespace Awe.Core.Widget.Domain;

[DependsOn(typeof(WidgetContractsModule))]
public class WidgetDomainModule : AbpModule
{
}