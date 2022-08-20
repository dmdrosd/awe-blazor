using Abp.Modules;
using Abp.Reflection.Extensions;
using TGrant.Awe.Core.Widget.Contracts;

namespace TGrant.Awe.Core.Page.Application;

[DependsOn(typeof(WidgetContractsModule))]
public class PageModule : AbpModule
{
    public override void Initialize()
    {
        IocManager.RegisterAssemblyByConvention(GetType().GetAssembly());
    }
}