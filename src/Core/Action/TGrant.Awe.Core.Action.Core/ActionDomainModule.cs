using Abp.Modules;
using Abp.Reflection.Extensions;
using TGrant.Awe.Core.Action.Contracts;

namespace TGrant.Awe.Core.Action.Core;

[DependsOn(typeof(ActionContractsModule))]
public class ActionDomainModule : AbpModule
{
    public override void Initialize()
    {
        IocManager.RegisterAssemblyByConvention(GetType().GetAssembly());
    }
}