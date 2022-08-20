using Abp;
using Abp.Castle.Logging.Log4Net;
using Castle.Facilities.Logging;
using TGrant.Awe.Core.Widget.Application.Interfaces;
using TGrant.Awe.Starter;

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