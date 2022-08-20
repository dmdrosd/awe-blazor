using Abp.Modules;
using Abp.Reflection.Extensions;
using Awe.Core.Action.Contracts;
using Awe.Core.Page.Application;

namespace Awe.Core.Action.Application;

[DependsOn(typeof(ActionContractsModule))]
[DependsOn(typeof(PageModule))]
public class ActionModule : AbpModule
{
    public override void Initialize()
    {
        IocManager.RegisterAssemblyByConvention(GetType().GetAssembly());
    }
}