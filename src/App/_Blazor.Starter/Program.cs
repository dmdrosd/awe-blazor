using _Blazor.Starter;
using Abp;
using Awe.Core.Widget.Application.Interfaces;

using (var bootstrapper = AbpBootstrapper.Create<BlazorStarterModule>())
{
    //bootstrapper.IocManager.IocContainer.AddFacility<LoggingFacility>(f =>
    //    f.UseAbpLog4Net().WithConfig("log4net.config"));

    bootstrapper.Initialize();

    bootstrapper.IocManager
        .Resolve<IWApplicationService>()
        .StartAsync(args);
}