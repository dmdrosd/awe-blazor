using Abp.Modules;
using Abp.Reflection.Extensions;
using TGrant.Awe.Core.Widget.Contracts;

namespace TGrant.Awe.Core.Widget.Domain;

[DependsOn(typeof(WidgetContractsModule))]
public class WidgetDomainModule : AbpModule
{
    public override void Initialize()
    {
        IocManager.RegisterAssemblyByConvention(GetType().GetAssembly());
    }
}