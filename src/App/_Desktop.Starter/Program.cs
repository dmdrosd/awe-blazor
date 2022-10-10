using Awe.Core.Widget.Application.Interfaces;
using Awe.Desktop.Starter;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using Serilog.Events;
using Volo.Abp;

Log.Logger = new LoggerConfiguration()
#if DEBUG
    .MinimumLevel.Debug()
#else
            .MinimumLevel.Information()
#endif
    .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
    .Enrich.FromLogContext()
    .WriteTo.Async(c => c.File("Logs/logs.txt"))
    .CreateLogger();

try
{
    Log.Information("Starting Desktop host.");

    var abpApplication = await AbpApplicationFactory.CreateAsync<DesktopStarterModule>(options =>
    {
        options.UseAutofac();
        options.Services.AddLogging(loggingBuilder => loggingBuilder.AddSerilog(dispose: true));
    });

    await abpApplication.InitializeAsync();

    Application.EnableVisualStyles();
    Application.SetCompatibleTextRenderingDefault(false);

    abpApplication.Services
        .GetRequiredService<IWApplicationService>()?
        .Start(args);
}
catch (Exception ex)
{
    Log.Fatal(ex, "Host terminated unexpectedly!");
}