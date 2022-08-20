using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Awe.Core.Page.Application;

[DependsOn(typeof(WidgetContractsModule))]
public class PageModule : AbpModule
{
    public override void Initialize()
    {
        IocManager.RegisterAssemblyByConvention(GetType().GetAssembly());
    }
}