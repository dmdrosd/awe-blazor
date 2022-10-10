using Awe.Core.Action.Core;
using Awe.Core.Widget.Contracts;
using Awe.Core.Widget.Domain;
using Awe.Platform.Wasm.View;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Emailing;
using Volo.Abp.MultiTenancy;

namespace Awe.Platform.Wasm.Domain;

[DependsOn(typeof(WidgetContractsModule))]
[DependsOn(typeof(WidgetDomainModule))]
[DependsOn(typeof(ActionDomainModule))]

[DependsOn(typeof(PlatformWasmViewModule))]
public class PlatformWasmDomainModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpMultiTenancyOptions>(options =>
        {
            options.IsEnabled = false;
        });

#if DEBUG
        context.Services.Replace(ServiceDescriptor.Singleton<IEmailSender, NullEmailSender>());
#endif
    }
}