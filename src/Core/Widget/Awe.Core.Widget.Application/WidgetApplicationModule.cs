using Abp.Modules;
using Abp.Reflection.Extensions;
using Awe.Core.Widget.Application.Interfaces;
using Awe.Core.Widget.Contracts;

namespace Awe.Core.Widget.Application;

[DependsOn(typeof(WidgetContractsModule))]
public class WidgetApplicationModule : AbpModule
{
    public override void PreInitialize()
    {
        base.PreInitialize();

        IocManager.Register<IWApplicationService, WApplicationService>();
    }

    public override void Initialize()
    {
        IocManager.RegisterAssemblyByConvention(typeof(WidgetApplicationModule).GetAssembly());
    }
}