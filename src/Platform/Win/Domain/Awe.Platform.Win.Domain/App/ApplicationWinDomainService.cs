using Abp.Dependency;
using Abp.Domain.Services;
using Awe.Core.Widget.Contracts.Domain;

namespace Awe.Platform.Win.Domain.App;

public class ApplicationWinDomainService : DomainService, IWApplicationDomainService, ISingletonDependency
{
    private readonly IWMainFormDomainService _mainFormDomainService;

    public ApplicationWinDomainService(IWMainFormDomainService mainFormDomainService)
    {
        _mainFormDomainService = mainFormDomainService;
    }

    public void Start(string[] args)
    {
        var mainForm = _mainFormDomainService.BuildMainForm(ProductInfo);
        System.Windows.Forms.Application.Run((Form)mainForm);
    }

    public Task StartAsync(string[] args)
    {
        throw new NotImplementedException();
    }

    public void Restart()
    {
        System.Windows.Forms.Application.Restart();
    }

    public string ProductInfo => System.Windows.Forms.Application.ProductName + "_" + GetVersion();
        
    private static string GetVersion()
    {
        //TODO получить версию программы
        return string.Empty;
        
        // return ApplicationDeployment.IsNetworkDeployed 
        //     ? ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString() 
        //     : "Debug";
    }
}