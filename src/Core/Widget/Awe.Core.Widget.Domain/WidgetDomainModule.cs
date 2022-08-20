using Abp.Modules;
using Abp.Reflection.Extensions;

using Awe.Core.Widget.Contracts;

namespace Awe.Core.Widget.Domain;

[DependsOn(typeof(WidgetContractsModule))]
public class WidgetDomainModule : AbpModule
{
    public override void Initialize()
    {
        IocManager.RegisterAssemblyByConvention(GetType().GetAssembly());
    }
}