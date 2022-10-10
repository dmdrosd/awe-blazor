using Awe.Core.Action.Contracts;
using Volo.Abp.Modularity;

namespace Awe.Core.Action.Core;

[DependsOn(typeof(ActionContractsModule))]
public class ActionDomainModule : AbpModule
{
}