using Awe.Core.Action.Contracts;
using Awe.Core.Page.Application;
using Volo.Abp.Modularity;

namespace Awe.Core.Action.Application;

[DependsOn(typeof(ActionContractsModule))]
[DependsOn(typeof(PageModule))]
public class ActionModule : AbpModule
{
}