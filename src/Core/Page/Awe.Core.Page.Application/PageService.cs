using Awe.Core.Widget.Contracts.Controller;
using Awe.Core.Widget.Contracts.View.Page;
using Volo.Abp.Application.Services;

namespace Awe.Core.Page.Application;

public class PageService : ApplicationService, IPageService
{
    private readonly IPageView _pageView;
    private IPageController _pageController;

    public PageService(IPageView pageView, IPageController pageController)
    {
        _pageView = pageView;
        _pageController = pageController;
    }

    public void Show()
    {
        _pageView.Show();
    }
}