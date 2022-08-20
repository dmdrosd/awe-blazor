using Abp.Dependency;
using TGrant.Awe.Core.Widget.Contracts.View;

namespace TGrant.Awe.Custom.Platform.Win.Domain.MainForm;

public class MainFormWinDomainService : IWMainFormDomainService, ISingletonDependency
{
    private readonly IMainFormView _mainFormView;
    private readonly IMainMenuDomainService _mainMenuDomainService;

    public MainFormWinDomainService(IMainFormView mainFormView, IMainMenuDomainService mainMenuDomainService)
    {
        _mainFormView = mainFormView;
        _mainMenuDomainService = mainMenuDomainService;
    }

    public IMainFormView BuildMainForm(string productInfo)
    {
        _mainMenuDomainService.Build();
        
        _mainFormView.Caption = productInfo;
        return _mainFormView;
    }
}