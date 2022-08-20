using Abp.Modules;
using Abp.Reflection.Extensions;
using Awe.Core.Action.Contracts;

namespace Awe.Core.Action.Core;

[DependsOn(typeof(ActionContractsModule))]
public class ActionDomainModule : AbpModule
{
    public override void Initialize()
    {
        IocManager.RegisterAssemblyByConvention(GetType().GetAssembly());
    }
}