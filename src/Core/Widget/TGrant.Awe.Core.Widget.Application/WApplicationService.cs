using Abp.Application.Services;
using Abp.Dependency;
using TGrant.Awe.Core.Widget.Application.Interfaces;
using TGrant.Awe.Core.Widget.Contracts.Domain;

namespace TGrant.Awe.Core.Widget.Application;

public class WApplicationService : ApplicationService, IWApplicationService, ISingletonDependency
{
    private readonly IWApplicationDomainService _wApplicationDomainService;

    public WApplicationService(IWApplicationDomainService wApplicationDomainService)
    {
        _wApplicationDomainService = wApplicationDomainService;
    }

    public string ProductInfo => _wApplicationDomainService.ProductInfo;

    public async Task StartAsync(string[] args)
    {
        await _wApplicationDomainService.StartAsync(args);
    }

    public void Restart()
    {
        _wApplicationDomainService.Restart();  
    }

    public void Start(string[] args)
    {
        _wApplicationDomainService.Start(args);  
    }
}