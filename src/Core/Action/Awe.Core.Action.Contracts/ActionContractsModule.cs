using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Awe.Core.Action.Contracts;

public class ActionContractsModule : AbpModule
{
    public override void Initialize()
    {
        IocManager.RegisterAssemblyByConvention(GetType().GetAssembly());
    }
}