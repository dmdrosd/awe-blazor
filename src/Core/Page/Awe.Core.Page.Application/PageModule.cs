using Volo.Abp.Modularity;

namespace Awe.Core.Page.Application;

[DependsOn(typeof(WidgetContractsModule))]
public class PageModule : AbpModule
{
}