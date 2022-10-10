using Awe.Core.Widget.Contracts;
using Awe.Core.Widget.Contracts.Domain;
using Awe.Core.Widget.Contracts.View.MainForm;
using Volo.Abp.DependencyInjection;

namespace Awe.Platform.Win.Domain.MainForm;

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