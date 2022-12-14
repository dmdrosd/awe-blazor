using Abp;
using Abp.Castle.Logging.Log4Net;
using Castle.Facilities.Logging;
using Awe.Core.Widget.Application.Interfaces;
using Awe.Desktop.Starter;

using (var bootstrapper = AbpBootstrapper.Create<DesktopStarterModule>())
{
    var iocManager = bootstrapper.IocManager;
    iocManager.IocContainer.AddFacility<LoggingFacility>(f =>
    {
        f.UseAbpLog4Net().WithConfig("log4net.config");
    });

    bootstrapper.Initialize();

    Application.EnableVisualStyles();
    Application.SetCompatibleTextRenderingDefault(false);

    iocManager
        .Resolve<IWApplicationService>()
        .Start(args);
}