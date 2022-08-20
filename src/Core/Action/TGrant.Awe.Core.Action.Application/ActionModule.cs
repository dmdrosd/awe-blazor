using Abp.Modules;
using Abp.Reflection.Extensions;
using TGrant.Awe.Core.Action.Contracts;
using TGrant.Awe.Core.Page.Application;

namespace TGrant.Awe.Core.Action.Application;

[DependsOn(typeof(ActionContractsModule))]
[DependsOn(typeof(PageModule))]
public class ActionModule : AbpModule
{
    public override void Initialize()
    {
        IocManager.RegisterAssemblyByConvention(GetType().GetAssembly());
    }
}